using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool IsPause;
    public GameObject menuSet;
    void Start()
    {
        IsPause = false;
    }

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
           menuSet.SetActive(true);
        }
    } 
}