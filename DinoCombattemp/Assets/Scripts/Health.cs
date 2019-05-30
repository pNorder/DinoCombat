using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public GameObject cowboy;
    static public float health = 5;
    
    static public bool knockBack = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     if(health <= 0)
        {
            SceneManager.LoadScene("Dead");
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            knockBack = true;
            if (AnimateOnKeypress.flippy == false)
            {
                cowboy.transform.position += Vector3.left * 1.5f * Time.deltaTime * 1500;
            }
            if(AnimateOnKeypress.flippy == true)
            {
                cowboy.transform.position += Vector3.right * 1.5f * Time.deltaTime * 1500;
            }
            health--;
            print("knockback");
            // Destroy(gameObject);
        }
        if (col.gameObject.tag.Equals("Explosion"))
        {
            knockBack = true;
            if (AnimateOnKeypress.flippy == false)
            {
                cowboy.transform.position += Vector3.up * 1.5f * Time.deltaTime * 500;
                cowboy.transform.position += Vector3.left * 1.5f * Time.deltaTime * 1500;
            }
            if (AnimateOnKeypress.flippy == true)
            {
                cowboy.transform.position += Vector3.up * 1.5f * Time.deltaTime * 500;
                cowboy.transform.position += Vector3.right * 1.5f * Time.deltaTime * 1500;
            }
            health = health - 3;
        }
        print(health);
    }
}

