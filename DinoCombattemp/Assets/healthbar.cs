using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthbar : MonoBehaviour
{
   public Image health;
    float phealth = 5;
    // Start is called before the first frame update
    void Start()
    {
       // health = GetComponent<Image>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("health " + Health.health);
        health.fillAmount = Health.health / phealth;
    }
}
