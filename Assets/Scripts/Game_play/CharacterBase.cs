using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterBase : MonoBehaviour
{
    float HP;
    public float Damage;
    float AttackSpeed;
    float Speed;
    float Deffence;
    float Range;
    private Rigidbody2D _playerRigidbody; // 사용할 리지드바디 컴포넌트
    Animator anim;
    public bool Back = false;
    public float backGauge; //전체 백게이지
    public float curbackGauge=10f; //현재 백게이지

    public float CurBackGauge{
        get{
            return curbackGauge;
        }set{
            curbackGauge=value;
            back.HandleBackgauge(curbackGauge);
        }
    }

    BackGauge back;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        back=GameObject.Find("Canvas").GetComponent<BackGauge>();

        _playerRigidbody = GetComponent<Rigidbody2D>();

        HP = barb.HP;
        Damage = barb.Damage;
        AttackSpeed = barb.AttackSpeed;
        Speed  = barb.Speed;
        Deffence = barb.Def;
        Range = barb.Range;
        backGauge = back.maxBackgauge;
        
        if (SceneManager.GetActiveScene().name == "Play") // 셀렉트 씬에서만 작동
        {
            anim.SetBool("Run", true);
        }

        

    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Back = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Back = false;
        }
        if (SceneManager.GetActiveScene().name == "Play") // 셀렉트 씬에서만 작동
        {
            if (Back == false)
            {
                Move();
                //Debug.Log($"CurBackGauge = {CurBackGauge}, backGauge = {backGauge}");
                if (CurBackGauge <= backGauge)
                {
                    CurBackGauge += Time.deltaTime;

                }
            }
            else
            {
                Back_Move();
            }
        }
        

        

    }


    //IEnumerator Attack_Speed()
    //{
        
    //}
    public void Move()
    {
        transform.Translate(0.002f*Speed,0,0);
        transform.localScale = new Vector3(1, 1, 1); // 왼쪽 바라보기
    }

    public void Back_Move()
    {
        if (CurBackGauge>=0)
        {
            transform.Translate(-0.002f * Speed, 0, 0);
            transform.localScale = new Vector3(-1, 1, 1); // 왼쪽 바라보기
            CurBackGauge -= 2*Time.deltaTime;
        }
    }
}
