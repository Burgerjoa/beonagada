using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;
    public static float maxHp = 100;
    public static float curHp = 100;
    public static float imsi;
    public static bool damaged_by_player;

    
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
        if (damaged_by_player == true)
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
        
    }

    private void HandleHp()
    {
        hpbar.value = Mathf.Lerp(hpbar.value, (float) curHp / (float) maxHp, Time.deltaTime * 10) ;
    }
    

  
}
