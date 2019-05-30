using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnimateOnKeypress : MonoBehaviour
{
    public SpriteRenderer sprite;
    public GameObject bullet;
        public GameObject b;
    public GameObject barrel;
    public Vector2 velocity;
    public bool canShoot = true;
    static public bool changer = false;
    public Vector2 offset = new Vector2(0.4f, -0.1f);
    public Vector2 flipOffset = new Vector2(-0.5f, -0.1f);
    public Vector2 barrelOffset = new Vector2(0.4f, -0.1f);
    public Vector2 barrelOffset1 = new Vector2(-0.4f, -0.1f);
    static public Vector2 barPos;
    // public Vector2 barrelOffset = new Vector2(0f, 0f);
    public int cooldown = 5;
    public KeyCode MyKey;
    public KeyCode MyKey2;
    public KeyCode MyKey3;
    public KeyCode MyKey4;
    public string MyTrigger;
    public string MyTrigger2;
    public string MyTrigger3;
    public string MyTrigger4;
    public string MyTigger5;
  //  public bool barrelExists = false;
   static public bool flippy = false;
    public bool canJump = true;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public float speed = 1.5f;
    public float targetTime = .2f;
   static public bool changer2 = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            StartCoroutine(CanJump());
            GetComponent<Animator>().SetTrigger(MyTigger5);
            transform.position += Vector3.up * speed * Time.deltaTime * 1000;
           
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetTrigger(MyTrigger4);
            flippy = true;
            sprite.flipX = true;
           

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            makeB();
        }   

        if (Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
            flippy = false;
            GetComponent<Animator>().SetTrigger(MyTrigger);
            
        }
        
        if (Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Animator>().SetTrigger(MyTigger5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().SetTrigger(MyTrigger2);
        }
        if (Input.GetKeyDown(KeyCode.Return) && canShoot)
        {
            if (!flippy)
            {
                print("shot");
                GetComponent<Animator>().SetTrigger(MyTrigger3);
                GameObject go = (GameObject)Instantiate(bullet, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * transform.localScale.x, velocity.y);
            }
            if (flippy)
            {
                GetComponent<Animator>().SetTrigger(MyTrigger3);
                GameObject go = (GameObject)Instantiate(bullet, (Vector2)transform.position + flipOffset * transform.localScale.x , Quaternion.identity);
                go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * transform.localScale.x *-1 , velocity.y);
            }
            StartCoroutine(CanShoot());
            // React();
        }

    }
    IEnumerator CanShoot()
    { 
      
            canShoot = false;
        yield return new WaitForSeconds(.5f);
        canShoot = true;
    }

    IEnumerator CanJump()
    {

        canJump = false ;
        yield return new WaitForSeconds(1f);
        canJump = true;
    }


    void makeB()
    {
        if (!flippy)
        {
            //barrelExplode.barrelExists = false;
            if (!barrelExplode.barrelExists)
            {
                GameObject b = (GameObject)Instantiate(barrel, (Vector2)transform.position + barrelOffset * transform.localScale.x, Quaternion.identity);
                barrelExplode.barrelExists = true;
                barPos = b.transform.position;

            }
         
        }
        if (flippy)
        {
            if (!barrelExplode.barrelExists)
            {
                GameObject b = (GameObject)Instantiate(barrel, (Vector2)transform.position + barrelOffset1 * transform.localScale.x, Quaternion.identity);
                barrelExplode.barrelExists = true;
                barPos = b.transform.position;
            }
            else
            {
                // Destroy(b, true);
                //  GameObject b = (GameObject)Instantiate(barrel, (Vector2)transform.position, Quaternion.identity);
                // barrelExists = true;

            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Horse"))
        {
            // Destroy(col.gameObject);
            cam1.enabled = false;
            cam2.enabled = true;
            React();
            // Destroy(gameObje
            
        }
        if (col.gameObject.tag.Equals("blackHorse"))
        {
            cam2.enabled = false;
            cam3.enabled = true;
            React2();
        }
        if (col.gameObject.tag.Equals("redHorse"))
        {
            SceneManager.LoadScene("Win");
        }
    }

    void React2()
    {
        changer = false;
        changer2 = true;
        transform.position = new Vector3(652, -32, 0);
    }
    void React()
    {
        changer = true;
        transform.position = new Vector3(300, -34.98657f, 0);
    }
}


