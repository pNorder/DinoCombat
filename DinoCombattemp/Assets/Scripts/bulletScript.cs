using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public int speed = 6;

// Function called once when the bullet is created
        void Start()
    {
        // Get the rigidbody component
        var r2d = GetComponent("Rigidbody2D");

        // Make the bullet move upward
        transform.position += Vector3.right * speed * Time.deltaTime * 40;
    }
    void OnTriggerEnter(Collider other)
    {
        print("hit");
    }

    // Function called when the object goes out of the screen
    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }
}
