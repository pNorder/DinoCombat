using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    //I have removed the "public gameobject other" since I'm assuming that this script is 
    //attached to the player.
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the player collider hits a gameobject with tag "Laser"
        //then the gameobject the script is attached to will be destroyed
        if (other.gameObject.tag == "egg")
            Destroy(this.gameObject);
        other.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}

