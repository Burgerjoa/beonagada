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
        // 서브메뉴
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