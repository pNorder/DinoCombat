using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDino : MonoBehaviour
{ public GameObject objDes;
    public GameObject objMake;
    public GameObject change;
    public int dinoHealth = 6;
    public int deadDinos = 0;
    public static bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if(dinoHealth <= 0 && deadDinos < 3)
        {
            dead = true;
            Destroy(objDes);
          
           // GameObject go = (GameObject)Instantiate(objMake, (Vector2)transform.position, Quaternion.identity);
        }
       // if(dinoHealth == 0 && deadDinos >=3)
        //{
          //  GameObject go = (GameObject)Instantiate(change, (Vector2)transform.position, Quaternion.identity);
        //}
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            Destroy(col.gameObject);
            dinoHealth--;
           // Destroy(gameObject);
        }

        if (col.gameObject.tag.Equals("Barrel"))
        {
            StartCoroutine(dinoPause());
        }

        if (col.gameObject.tag.Equals("Explosion"))
        {
            print("exp");
            dinoHealth = dinoHealth - 3;
            print(dinoHealth);
        }
        if (col.gameObject.tag.Equals("Player"))
        {
              if (col.transform.position.x < transform.position.x)
              {
                print("left");
            col.transform.position += Vector3.left * 1.5f * Time.deltaTime * 1000;
            }
            //   if (AnimateOnKeypress.flippy == false)
             if (col.transform.position.x > transform.position.x)
            {
                print("right");
                col.transform.position += Vector3.right * 1.5f * Time.deltaTime * 1000;
            }
            Health.health--;
        }
    }

    IEnumerator dinoPause()
    {

       
        yield return new WaitForSeconds(1f);
        
    }
}
