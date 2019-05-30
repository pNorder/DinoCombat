using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelExplode : MonoBehaviour
{
    public int barrelHealth = 2;
    public GameObject barrel;
    static public bool barrelExists;
    static public bool exp;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            Destroy(col.gameObject);
            barrelHealth--;
            
            // Destroy(gameObject);
        }
        if (col.gameObject.tag.Equals("Enemy"))
        {
            Destroy(barrel);
            barrelExists = false;
        }
    }

    void Update()
    {
        if (barrelHealth == 0)
        {
            Destroy(barrel);
            barrelExists = false;
            exp= true;
        }
    }
}
