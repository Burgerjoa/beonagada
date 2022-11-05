using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Now_level : MonoBehaviour
{
    public Text nowLevel;
    // Start is called before the first frame update
    void Start()
    {
        nowLevel.text =CharacterBase._level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        nowLevel.text =CharacterBase._level.ToString();

    }
}
