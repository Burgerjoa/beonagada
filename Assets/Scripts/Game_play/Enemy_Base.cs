using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
/*using UnityEngine.UI;*/ // Image 자료형을 위해 using 해줘야 함
public class Enemy_Base : MonoBehaviour
{

    public int Hp = 3;
    public Player slime;
    private bool ishurt = false;

    public float speed;

    private bool iskcockback= false;

    private Rigidbody2D rigid;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Define.isPause == false)
        {
            transform.Translate(-0.002f,0,0);
            if(Hp <= 0)
            {

                
                Destroy(this.gameObject);
            }
        }


    }
    [FormerlySerializedAs("sword_man")] public Player player;
    private void OnCollisionEnter2D(Collision2D col) //피격 판정
    {
        if (col.transform.tag=="PlayerAttackRange")
        {
            Hurt(col.transform.position);
        }
        if (col.transform.tag == "Player")
        {
            GameObject canvas = GameObject.Find("Canvas");
            canvas.GetComponent<UI>().HitPlayer();
        }
    }

    public void Hurt(Vector2 pos)
    {
        if (!ishurt)
        {
            ishurt = true;
            if (Hp <= 0)// 적 사망
            {
            }
            else
            {
                float x = transform.position.x - pos.x;
                if (x < 0)
                    x = 1;
                else
                    x = -1;
                StartCoroutine(Knockback(x));
                //StartCoroutine(alphablink());
            }
            
        }
        
    }
    public void TakeDamage(int damage)//적 체력 0일 때 사라짐
    {
        Hp = Hp - damage;
        Destroy(gameObject);
    }

    IEnumerator Knockback(float dir)
    {
        ishurt=false;
        iskcockback = true;
        float ctime = 0;
        Debug.Log("AddForce");
        rigid.AddForce(Vector2.right*5f, ForceMode2D.Impulse);

        // TODO 넉백 로직 수정

        yield return new WaitForSeconds(1f);

        rigid.velocity = Vector2.zero;
        // while (ctime < 0.2f)
        // {
        //     if (transform.rotation.y==0)
        //     {
        //         transform.Translate(0.2f,0,0);
                    
        //         //transform.Translate(Vector2.down*speed*Time.deltaTime*dir*3);
        //     }
        //     else
        //     {
        //         transform.Translate(0.2f,0,0);
        //         //transform.Translate(Vector2.down*speed*Time.deltaTime*dir*3);
        //     }

        //     ctime += Time.deltaTime;
        //     yield return null;
            
        // }

        iskcockback = false;

        yield return null;
    }
/*
    IEnumerator alphablink()
    {
        while (ishurt)
        {
            yield return new WaitForSeconds(0.1f);
            sr.color = halfA;
            yield return new WaitForSeconds(0.1f);
            sr.color = fullA;

        }
    }
*/

}
