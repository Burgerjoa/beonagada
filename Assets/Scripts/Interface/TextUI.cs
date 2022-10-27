using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    public Text ScriptTxt;


    int Gold = 0;                    


    // Use this for initialization
    void Start()
    {
        ScriptTxt.text = "0";
    }
    
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Gold += 1;
            ScriptTxt.text = Gold.ToString();
        }
    }
}
