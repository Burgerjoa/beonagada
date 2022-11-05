using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGauge : MonoBehaviour
{
    [SerializeField]
    private Slider Backgaugebar;
    public float maxBackgauge = 10;
    public float curBackgauge = 10;
    public float ims;

    
    void start()
    {
        Backgaugebar.value = (float) curBackgauge / (float) maxBackgauge;
    }

    void Update()
    {
        // if(Input.GetMouseButton(0))
        // {
        //     if(curBackgauge > 0)
        //     {
        //         curBackgauge -= 0.01f;
        //     }
        //     else
        //     {
        //         curBackgauge = 0;
        //     }
        //     ims = (float)curBackgauge / (float)maxBackgauge;
        // }else
        // {
        //     curBackgauge += 0.01f;
        // }
        // HandleBackgauge();
    }

    public void HandleBackgauge(float cur)
    {
        Backgaugebar.value = Mathf.Lerp(Backgaugebar.value, (float) cur / (float) maxBackgauge, Time.deltaTime * 10) ;
    }
}
