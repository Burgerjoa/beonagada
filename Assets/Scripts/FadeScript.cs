using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
   private Image image;

   private void Awake()
   {
     image = GetComponent<Image>();
   } 
   private void Update()
   {
    Color color = image.color;
    if(color.a < 1)
    {
        color.a += Time.deltaTime;
    }
    image.color = color;
   }
}
