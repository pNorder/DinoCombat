using UnityEngine;
using System.Collections;

public class DinoWalk : MonoBehaviour
{
    //  public float speed = 1.5f;
    public string MyTrigger;
    public string MyTrigger2;
    private bool dinoMove = true;
    public SpriteRenderer sprite;
    private GameObject Player;//set target from inspector instead of looking in Update
    public float speed = 30f;

    void Start()
    {
        dinoMove = true;
    }
    void Update()
    {
        if (dinoMove)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            if (Player.transform.position.x < transform.position.x)
            {
                sprite.flipX = false;
                transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
                GetComponent<Animator>().SetTrigger(MyTrigger);
            }
            if (Player.transform.position.x > transform.position.x)
            {
                sprite.flipX = true;
                transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
                GetComponent<Animator>().SetTrigger(MyTrigger);
            }
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Barrel"))
        {  
            StartCoroutine(dinoPause());
        }
        if (col.gameObject.tag.Equals("Wall"))
        {
           this.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        }

    IEnumerator dinoPause()
    {

        dinoMove = false;
        yield return new WaitForSeconds(1f);
        dinoMove = true;
    }
}
