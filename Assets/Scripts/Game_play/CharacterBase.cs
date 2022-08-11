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
    
    // Start is called before the first frame update
    void Start()
    {
        Speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        transform.Translate(Speed/1000,0,0);
    }
    
}
