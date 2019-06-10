using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class load : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
    }

    public void onClikc()
    {
        StartCoroutine(Pause());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Pause()
    {

        text.enabled = true;
        yield return new WaitForSeconds(2f);
        text.enabled = false;
    }
}
