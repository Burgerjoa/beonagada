/*
using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [Serializable]
    public class classStats
    {
        public int hp,atk,def;
        public string class_name;

        public void PrintNumbers()
        {
            string str = "numbers : ";
            str +=class_name+""+ hp +" "+ atk+ " " + def;

            Debug.Log(str);

        }
    }


    public class charStats
    {
        public classStats[] Classes;
    }

    public void Start()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("Scripts/Stats/stat.jsonr");

        charStats lottoList = JsonUtility.FromJson<charStats>(textAsset.text);

        foreach(classStats lt in lottoList.Classes)
        {
            lt.PrintNumbers();
            Debug.Log("=============");
        }

        string classToJson = JsonUtility.ToJson(lottoList);
        Debug.Log(classToJson);
    }
}
*/

using System; /* for Serializable */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [Serializable]
    public class Lotto
    {
        public int id;
        public string date;
        public int[] number;
        public int bonus;

        public void printNumbers()
        {
            string str = "numbers : ";
            for (int i = 0; i < 6; i++) str += number[i] + " ";

            Debug.Log(str);
            Debug.Log("bonus : " + bonus);
        }
    }

    public class LottoNumbers
    {
        public Lotto[] winning;
    }

    void Start()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("LottoWinningNumber.json");

        LottoNumbers lottoList = JsonUtility.FromJson<LottoNumbers>(textAsset.text);

        foreach(Lotto lt in lottoList.winning)
        {
            lt.printNumbers();
            Debug.Log("=============");
        }

        string classToJson = JsonUtility.ToJson(lottoList);
        Debug.Log(classToJson);
    }
}