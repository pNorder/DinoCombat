using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public GameObject Username;
    public string username;
    private string form;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoginButton()
    {  if (username != "")
        {
            print("Login Sucessful");
            Application.LoadLevel("Server_Select");
        }
    }


    // Update is called once per frame
    void Update()
    {
        username = Username.GetComponent<InputField>().text;
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(username != "")
            {
                LoginButton();
            }
        }
        
    }
}
