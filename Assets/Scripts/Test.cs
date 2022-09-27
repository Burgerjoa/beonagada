using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public private void Start()
    {
        Debug.Log("Hello, Unity!");

        int level = 5; //정수형
        float strength = 15.5f; //실수형
        string playerName = "김경민"; //문자형
        bool isFullLevel = false or true ; //논리형 
        string[] monsters = {"슬라임", "사막뱀", "악마"}; 
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 10;

        Debug.Log(level);
        Debug.Log(strength);
        Debug.Log(playerName);
        Debug.Log(isFullName);
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("공책")
        items.Add("필통")

        Debug.Log(items[0]);
        Debug.Log(itmes[1]);

        itmes.RemoveAt(0)

        int exp = 1500;
        exp = 1500 + 320;
        exp = exp -10;
        level = exp / 300;
        strength = level * 3.1f;
        
        Debug.Log(exp);
        Debug.Log(level);
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log(title + "" + playerName);
    }
}