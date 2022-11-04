using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    public int hp = 2;
    bool isHurt;

    SpriteRenderer sr;
    Color halfA = new Color(1, 1, 1, 0.5f);
    Color fullA = new Color(1, 1, 1, 1);
    public float speed;

    bool isknockback = false;

    public AudioClip impact;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
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
            hp = hp - damage;
            if(hp<=0)
            {               
            }
            else
            {
                anim.SetTrigger("hurt");
                audio.clip = impact;
                audio.Play();
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

    IEnumerator Knockback(float dir)
    {
        isknockback = true;
        float ctime = 0;
        while(ctime < 0.2f)
        {
            if(transform.rotation.y == 0)
               transform.Translate(Vector2.left*speed*Time.deltaTime*dir);
            else
               transform.Translate(Vector2.left*speed*Time.deltaTime*-1f*dir);
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
        yield return new WaitForSeconds(1f);
        isHurt = false;
    }

    void Update()
    {
          if(!isknockback)
            walk();
    }

    public float walk_speed;
    void walk()
    {
        float hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(Mathf.Abs(hor) * walk_speed * Time.deltaTime, 0, 0));
        if (hor > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (hor < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
