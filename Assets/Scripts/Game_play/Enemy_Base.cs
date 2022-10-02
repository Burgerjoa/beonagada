using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI; // Image 자료형을 위해 using 해줘야 함
public class Enemy_Base : MonoBehaviour
{

    public int maxHp;
    public int nowHp;
    public int atkDmg;
    public int atkSpeed;
    public Player slime;
    Image nowHpbar;
    private RectTransform hpBar;
    private bool ishurt = false;

    public float speed;

    private bool iskcockback= false;




    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    [FormerlySerializedAs("sword_man")] public Player player;
    private void OnTriggerEnter2D(Collider2D col) //피격 판정
    {
        if (col.CompareTag("Player"))
        {
            Hurt(col.transform.position);
        

        }
    }

    public void Hurt(Vector2 pos)
    {
        if (!ishurt)
        {
            ishurt = true;
            if (nowHp <= 0)// 적 사망
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

    IEnumerator Knockback(float dir)
    {
        iskcockback = true;
        float ctime = 0;
        while (ctime < 0.2f)
        {
            if (transform.rotation.y==0)
            {
                transform.Translate(5f,0,0);
                    
                //transform.Translate(Vector2.down*speed*Time.deltaTime*dir*3);
            }
            else
            {
                transform.Translate(5f,0,0);
                //transform.Translate(Vector2.down*speed*Time.deltaTime*dir*3);
            }

            ctime += Time.deltaTime;
            yield return null;
            
        }

        iskcockback = false;
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
