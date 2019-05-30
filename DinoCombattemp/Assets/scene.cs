using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
        SceneManager.LoadScene("Dino_Combat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
