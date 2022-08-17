using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class barb : MonoBehaviour
{
    public float HP;
    public float Damage;
    public float AttackSpeed;
    public static float Barb_Speed;
    public float Deffence;
    public float Range;
    public GameObject obj;
    private Rigidbody2D _playerRigidbody; // 사용할 리지드바디 컴포넌트


    // Start is called before the first frame update
    void Start()
    {
        Barb_Speed = 10f;
        //obj.GetComponent<CharacterBase>().a = "ddd";

    }


}