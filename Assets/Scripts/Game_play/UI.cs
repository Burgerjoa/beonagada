using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;
    private float maxHp = 100;
    public static float curHp = 100;
    float imsi;
    
    void start()
    {
        hpbar.value = (float) curHp / (float) maxHp;
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(curHp > 0)
            {
                curHp -= 10;
            }
            else
            {
                curHp = 0;
            }
            imsi = (float)curHp / (float)maxHp;
        }
        
        HandleHp();
        void OnTriggerEnter2D(Collider2D col) //피격 판정
        {
            if (col.CompareTag("Player"))
            {
                if (true)
                {
                    curHp -= 10f;
                }

            }
        }
    }

    private void HandleHp()
    {
        hpbar.value = Mathf.Lerp(hpbar.value, (float) curHp / (float) maxHp, Time.deltaTime * 10) ;
    }
    

  
}
