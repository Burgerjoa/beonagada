using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterBase : MonoBehaviour
{
    public float HP;
    public float Damage;
    float AttackSpeed;
    public float Speed;
    float Deffence;
    float Range;
    private Rigidbody2D _playerRigidbody; // 사용할 리지드바디 컴포넌트
    Animator anim;
    public bool Back = false;
    public float backGauge; //전체 백게이지
    public float curbackGauge=10f; //현재 백게이지
    bool isHurt;
    private bool isknockback= false;
    SpriteRenderer sr;
    private float _currentExp;
    public static int _level;
    private float _maxExp;
    bool Death = false;
    
    
    Color halfA = new Color(1, 1, 1, 0.5f);
    Color fullA = new Color(1, 1, 1, 1);

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
        sr = GetComponent<SpriteRenderer>();
        back=GameObject.Find("Canvas").GetComponent<BackGauge>();

        _playerRigidbody = GetComponent<Rigidbody2D>();

        //HP = barb.HP;
        Damage = barb.Damage;
        AttackSpeed = barb.AttackSpeed;
        Speed  = barb.Speed;
        Deffence = barb.Def;
        Range = barb.Range;
        backGauge = back.maxBackgauge;
        _currentExp = 0;
        
        
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

        if (Input.GetMouseButtonDown(1))
        {
            _currentExp += 5;
        }

        if (_currentExp >= _maxExp)
        {
            _level++;
            _maxExp = Mathf.Pow(1.2f,_level);
            _currentExp = 0;

        }
        Debug.Log(_currentExp);
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("EnemyAtk"))
        {
            Hurt(collision.GetComponentInParent<Enemy>().damage,collision.transform.position);
        }
    }

    public void Hurt(int damage, Vector2 pos)
    {
        if(!isHurt)
        {   
            isHurt = true;
            HP = HP - damage;
            if(HP<=0)
            {               
            }
            else
            {               
                float x = transform.position.x - pos.x;
                if(x<0)
                   x = 1;
                else
                   x = -1;
                StartCoroutine(Knockback(x));
                StartCoroutine(HurtRoutine());
                StartCoroutine(alphablink());
            }
        }
    }
    public void isDeath()
    {
        anim.SetBool("Death", true);
        Death = true;
        Speed = 0;

    }

    IEnumerator Knockback(float dir)
    {   
        isknockback = true;
        float ctime = 0;
        while(ctime < 0.2f)
        {
            if(transform.rotation.y == 0)
               transform.Translate(Vector2.left*Speed*Time.deltaTime*dir);
            else
               transform.Translate(Vector2.left*Speed*Time.deltaTime*-1f*dir);
            ctime += Time.deltaTime;
            yield return null;
        }
        isknockback = false;
    }

    IEnumerator alphablink()
    {
        while(isHurt)
        {
            yield return new WaitForSeconds(0.1f);
            sr.color = halfA;
            yield return new WaitForSeconds(0.1f);
            sr.color = fullA;
        }
    }

    IEnumerator HurtRoutine()
    {   
        yield return new WaitForSeconds(0.5f);
        isHurt = false;
    }

}