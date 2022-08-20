using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabButton : MonoBehaviour
{
    Image background;
    public Sprite idlelmg;
    public Sprite selectedlmg;
    private void Awake()
    {
        background = GetComponent<Image>();
    }
    public void Selected()
    {
        background.sprite = selectedlmg;
    }
    public void DeSelected()
    {
        background.sprite = idlelmg;
    }
}
