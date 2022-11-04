using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Animator animator;
    public bool LeftMove = false;
    Vector3 moveVelocity = Vector3.zero;
    float moveSpeed = 4;

    void start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if(LeftMove)
        {
            animator.SetBool("Direction", false);
            moveVelocity = new Vector3(-0.10f, 0, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
    }
}
