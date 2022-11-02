using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<PlayerData>();
                if(instance == null)
                {
                    var instanceContainer = new GameObject("PlayerData");
                    instance = instanceContainer.AddComponent<PlayerData>();
                }
            }
            return instance;
        }
    }
    private static PlayerData instance;

   
    public GameObject Player;
    public GameObject FireBall; //πﬂªÁ√º
    public GameObject ItemExp;
    public List<int> PlayerSkill = new List<int>();

    public int PlayerLv = 1;
    public float PlayerCurrentExp = 0f;
    public float PlayerLvUpExp = 100f;
    public void PlayerExpCalc(float exp)
    {
        PlayerCurrentExp += exp;
        if (PlayerCurrentExp >= PlayerLvUpExp) ;
        {
            PlayerLv++;
            PlayerCurrentExp -= PlayerLvUpExp;
            PlayerLvUpExp *= 1.3f;
            StartCoroutine(PlayerLevelUp());

        }
    }
    IEnumerator PlayerLevelUp()
    {
        yield return null;
        yield return new WaitForSeconds(1.5f);
        UI.Instance.PlayerLvUp(true);
        yield return new WaitForSeconds(1.5f);
        
    }
}
