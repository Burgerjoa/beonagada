using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Animator animator;
    Rigidbody2D myrigidbody;
    float speed = 3;
    public void Start()
    {
        animator = GetComponent<Animator>();
        myrigidbody = GetComponent<Rigidbody2D>();

    }
    private float curTime;
    public float coolTime = 0.5f;
    public Transform pos;
    public Vector2 boxSize;
    public void Update()
    {
           if(curTime <= 0)
           {
               if (Input.GetKey(KeyCode.Z))
               {
                Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position, boxSize, 0);
                animator.SetTrigger("Attack");
                curTime = coolTime;
               }
           }
           else
           {
               curTime -= Time.deltaTime;
           }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(pos.position, boxSize);

    }


}
