using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterBase : MonoBehaviour
{
    float HP;
    float Damage;
    float AttackSpeed;
    float Speed;
    float Deffence;
    float Range;
    private Rigidbody2D _playerRigidbody; // 사용할 리지드바디 컴포넌트

    
    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();

        HP = barb.HP;
        Damage = barb.Damage;
        AttackSpeed = barb.AttackSpeed;
        Speed  = barb.Speed;
        Deffence = barb.Def;
        Range = barb.Range;

    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Play") // 셀렉트 씬에서만 작동
        {
            move();
        }
    }


    public void move()
    {
        transform.Translate(0.002f*Speed,0,0);
    }
    
}
