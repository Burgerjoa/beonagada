using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class barb : MonoBehaviour
{
    public static float HP;
    public static float Damage;
    public static float AttackSpeed;
    public static float Speed;
    public static float Def;
    public static float Range;
    public GameObject obj;
    private Rigidbody2D _playerRigidbody; // 사용할 리지드바디 컴포넌트


    // Start is called before the first frame update
    void Start()
    {
        HP = 1000f;
        Damage = 10f;
        AttackSpeed = 10f;
        Speed = 10f;
        Def = 10f;
        Range = 3f;

        //obj.GetComponent<CharacterBase>().a = "ddd";

    }


}