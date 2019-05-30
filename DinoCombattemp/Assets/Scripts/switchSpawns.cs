using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchSpawns : MonoBehaviour
{
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    // Start is called before the first frame update
    void Start()
    {
        spawn1.SetActive(true);
        spawn2.SetActive(false);
        spawn3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimateOnKeypress.changer)
        {
            spawn1.SetActive(false);
            spawn2.SetActive(true);
          
        }
        if (AnimateOnKeypress.changer2)
        {
            spawn2.SetActive(false);
            spawn3.SetActive(true);
        }
    }
}
