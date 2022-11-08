using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI Instance;
    private static UI instance;
    [SerializeField]
    private Slider hpbar;
    public Slider Expbar;
    public int playerLv = 1;
    [SerializeField]
    private float curExp = 0f;
    [SerializeField]
    private float playerExp = 100f;

    public float CurExp
    {
        get
        {
            return curExp;
        }
        set
        {
            curExp += value;
            if (curExp >= playerExp)
            {
                Debug.LogWarning("LV UP");
                curExp -= playerExp;
                Time.timeScale = 0f;
                Define.isPause = true;
                PlayerLv++;
            }
        }
    }

    public float PlayerLv
    {
        get
        {
            return playerLv;
        }
        set
        {
            // TODO: 슬롯머신 관련
            SlotMachineGo.SetActive(true);
        }
    }

    public static float maxHp = 500;
    public static float curHp = 500;
    public float imsiHp;
    public bool damaged_by_player = true;
    public GameObject GameOverScreen;
    public GameObject SlotMachineGo;
    public GameObject EndGameGo;

    public Text PlayerExpBar;
    public Text PlayerLvText;

    void Start()
    {
        hpbar.value = (float) curHp / (float) maxHp;
    }
    
    void Update()
    {
        // 피달기 테스트용
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(curHp > 0)
            {
                curHp -= 10f;
            }
            else
            {
                curHp = 0;
            }
            imsiHp = (float)curHp / (float)maxHp;
            HandleHp();
        }
        
        if(curHp <=0 )
        {
            Destroy(hpbar.gameObject);
           
            GameOverScreen.SetActive(true);

        }
       
        
    }
    public void HitPlayer()
    {
        if (damaged_by_player == true)
        {
            StartCoroutine("PlayerHited");
            if (curHp > 0)
            {
                curHp -= 10f;
            }
            else
            {
                curHp = 0;
            }
            imsiHp = (float)curHp / (float)maxHp;
        }

        HandleHp();
    } 
    public void PlayerLvUp(bool isSlotMachineOn)
    {
        if(isSlotMachineOn)
        {
            SlotMachineGo.SetActive(true);
        }
        else
        {
            SlotMachineGo.SetActive(false);
        }
    }

    public void HandleHp()
    {
        //hpbar.value = Mathf.Lerp(hpbar.value, (float) curHp / (float) maxHp, Time.deltaTime * 10) ;
        hpbar.value = (float)curHp / (float)maxHp;
    }
    
    IEnumerator PlayerHited()
    {
        damaged_by_player = false;
        yield return new WaitForSeconds(0.3f);
        damaged_by_player = true;
    }
  
}
