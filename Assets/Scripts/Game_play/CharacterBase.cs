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
    public float backGauge;


    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        _playerRigidbody = GetComponent<Rigidbody2D>();

        HP = barb.HP;
        Damage = barb.Damage;
        AttackSpeed = barb.AttackSpeed;
        Speed  = barb.Speed;
        Deffence = barb.Def;
        Range = barb.Range;
        backGauge = 10f;

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
                if (backGauge <= 10f)
                {
                    backGauge += Time.deltaTime;

                }
            }
            else
            {
                Back_Move();
            }
        }
        
        anim.SetBool("Attack", true);

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
        if (backGauge>=0)
        {
            transform.Translate(-0.002f * Speed, 0, 0);
            transform.localScale = new Vector3(-1, 1, 1); // 왼쪽 바라보기
            backGauge -= Time.deltaTime;
            Debug.Log(backGauge);
        }
    }
}
