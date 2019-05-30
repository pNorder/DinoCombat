using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnDino : MonoBehaviour
{
    public GameObject dino1;
    public GameObject dino2;
    public GameObject egg;
    public GameObject horse;
    public static int dinoKills = 0;
   public Vector2 horseOffset = new Vector2 (0.4f , -0.5f);
    public bool eggLay;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject go = (GameObject)Instantiate(egg, (Vector2)transform.position, Quaternion.identity);
        Destroy(go, 1f);
        StartCoroutine(makeDino1());
    }

    // Update is called once per frame
    void Update()
    {
        
            if (destroyDino.dead)
            {
                dinoKills++;
           
          //  destroyDino.dead = false;
            
               // StartCoroutine(eggHatch());
                if (dinoKills < 8)
            {
                GameObject go = (GameObject)Instantiate(egg, (Vector2)transform.position, Quaternion.identity);
                Destroy(go, 1f);
                if (dinoKills % 2 == 0)
                    {
                   StartCoroutine(makeDino1());
                    }
                    if (dinoKills % 2 == 1)
                    {

                    StartCoroutine(makeDino2());

                    }

                }
                else
            {
                GameObject go = (GameObject)Instantiate(horse, (Vector2)transform.position + horseOffset * transform.localScale.x, Quaternion.identity);
            }

            }
        destroyDino.dead = false;
    }
    

    IEnumerator eggHatch()
    {
        eggLay = false;
        yield return new WaitForSeconds(1f);
        eggLay = true;
    }

    IEnumerator makeDino1()
    {
        yield return new WaitForSeconds(1f);
        GameObject g = (GameObject)Instantiate(dino1, (Vector2)transform.position, Quaternion.identity);
        
        
    }

    IEnumerator makeDino2()
    {
        yield return new WaitForSeconds(1f);
        GameObject g = (GameObject)Instantiate(dino2, (Vector2)transform.position, Quaternion.identity);
  
       
    }
}
