using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public float HP;
    public float Damage;
    public float AttackSpeed;
    public float Speed;
    public float Deffence;
    public float Range;
    private Rigidbody2D _playerRigidbody; // 사용할 리지드바디 컴포넌트

    
    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        Speed = barb.Barb_Speed;
    }

    private void Update()
    {
        move();
    }


    public void move()
    {
        Debug.Log(Speed);
        //transform.Translate(0.1f,0,0);
    }
    
}
