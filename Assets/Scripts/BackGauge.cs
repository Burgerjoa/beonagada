/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGauge : MonoBehaviour
{
    [SerializeField]
    private Slider Backgaugebar;
    public static float maxBackgauge = 5;
    public static float curBackgauge = 5;
    public static float ims;

    
    void start()
    {
        Backgaugebar.value = (float) curBackgauge / (float) maxBackgauge;
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(curBackgauge > 0)
            {
                curBackgauge -= 0.1;
            }
            else
            {
                curBackgauge = 0;
            }
            ims = (float)curBackgauge / (float)maxBackgauge;
        }
        HandleBackgauge();
    }

    private void HandleBackgauge()
    {
        Backgaugebar.value = Mathf.Lerp(Backgaugebar.value, (float) curBackgauge / (float) maxBackgauge, Time.deltaTime * 10) ;
    } 
}
*/