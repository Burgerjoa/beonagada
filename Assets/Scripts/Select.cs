using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    public Character character;
    Animator anim;
    SpriteRenderer sr;
    public Select[]chars;

    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        if(DataMgr.instance.currentCharacter == character)OnSelect();
        else OnDeSelect();
    }
  
    private void OnMouseUpAsButton()
    {
        if (SceneManager.GetActiveScene().name == "Select") // 셀렉트 씬에서만 작동
        {

            DataMgr.instance.currentCharacter = character;
            OnSelect();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != this) chars[i].OnDeSelect();
            }
        }
    }

    // 일단은 사용안함
    void OnDeSelect()
    {
        if (SceneManager.GetActiveScene().name == "Select") // 셀렉트 씬에서만 작동
        {
            anim.SetBool("Attack", false);
            sr.color = new Color(0.5f, 0.5f, 0.5f);
        }
    }

    void OnSelect()
    {
        if (SceneManager.GetActiveScene().name == "Select") // 셀렉트 씬에서만 작동
        {
            anim.SetBool("isSelect", true);
            anim.SetBool("Attack", true);
            sr.color = new Color(1f, 1f, 1f);
        }
    }
}