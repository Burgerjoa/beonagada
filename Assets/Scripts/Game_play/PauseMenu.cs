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

            if (menuSet.activeSelf)
            {
                menuSet.SetActive(false);
                Time.timeScale = 1f;
                Define.isPause = false;
            }
           else
           {
                Debug.LogError("open menu");
                Define.isPause = true;
                menuSet.SetActive(true);
                Time.timeScale = 0f;
           }
        }
        Debug.LogWarning("scale : " + Time.timeScale);
    } 
    public void GameExit()
    {
        Application.Quit();
    }
}