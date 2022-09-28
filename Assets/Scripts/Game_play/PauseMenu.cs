using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menuSet;
    void Start()
    {
       
    }

    void Update()
    {   //sum menu
        if(Input.GetButtonDown("Cancel"))
        {
           if(menuSet.activeSelf)
              menuSet.SetActive(false);
           else 
              menuSet.SetActive(true);
        }
    } 
    public void GameExit()
    {
        Application.Quit();
    }
}