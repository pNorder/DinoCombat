using UnityEngine;
using System.Collections;

public class CowboyWalk : MonoBehaviour
{
    public float speed = 1.5f;
    public bool canJump = true;

    void Update()
    { /*
        if (Input.GetKey(KeyCode.W) && canJump)
        {
            transform.position += Vector3.up * speed * Time.deltaTime * 1500;

            StartCoroutine(CanJump());

        }
        */
            if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime  *40;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime * 40;
        }
        if (Input.GetKey(KeyCode.S))
        {
           // transform.position += Vector3.down * speed * Time.deltaTime * 40;
        }
    }
    IEnumerator CanJump()
    {

        canJump = false;
        yield return new WaitForSeconds(1.2f);
        canJump = true;
    }
}