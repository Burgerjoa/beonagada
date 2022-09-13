using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Enemy_Base : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 5f;
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
        transform.Translate(-0.002f*Speed,0,0);
    }
}
