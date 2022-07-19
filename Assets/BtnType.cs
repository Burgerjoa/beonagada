using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BtnType : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
   public BTNType currentType;
   public Transform buttonScale;
   Vector3 defaultScale;
   public CanvasGroup mainGroup;
   public CanvasGroup OptionGroup;

   private void Start()
   {
      defaultScale = buttonScale.localScale;
   }
   bool isSound;
   public void OnBtnClick()
   {
      switch(currentType)
      {
        case BTNType.Start:
          SceneLoader.LoadSceneHandle("Play", 0);
          break;
        case BTNType.Continue:
          SceneLoader.LoadSceneHandle("Play", 1);
          break;
        case BTNType.Stat:
          Debug.Log("Stat");
          break;
        case BTNType.Option:
          CanvasGroupOn(OptionGroup);
          CanvasGroupOff(mainGroup);
          break;
        case BTNType.SoundOn:
          if(isSound)
          {
            Debug.Log("soundoff");
          }
          else
          {
            Debug.Log("soundon");
          }
          isSound = !isSound;
          break;
        case BTNType.Coupon:
          Debug.Log("coupon");
          break;
        case BTNType.Languauge:
          Debug.Log("languauge");
          break;
        case BTNType.Quit:
          CanvasGroupOn(mainGroup);
          CanvasGroupOff(OptionGroup);
          break;
        case BTNType.Exit:
          Application.Quit();
          Debug.Log("exit");
          break;
      }
   }
   public void CanvasGroupOn(CanvasGroup cg)
   {
      cg.alpha = 1;
      cg.interactable = true;
      cg.blocksRaycasts = true;
   }
   public void CanvasGroupOff(CanvasGroup cg)
   {
      cg.alpha = 0;
      cg.interactable = false;
      cg.blocksRaycasts = false;
   }
   public void OnPointerEnter(PointerEventData eventData)
   {
     buttonScale.localScale = defaultScale*1.2f;
   }
   public void OnPointerExit(PointerEventData eventData)
   {
     buttonScale.localScale = defaultScale;
   }
}
