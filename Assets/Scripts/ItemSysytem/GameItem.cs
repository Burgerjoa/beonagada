using System;
using UnityEngine;

namespace ItemSysytem
{
    public class GameItem : MonoBehaviour
    {
        [SerializeField] private ItemStack _stack;
        [SerializeField] private SpriteRenderer _spriteRenderer;

        private void OnValidate()
        {
            SetupGameObject();
        }

        private void SetupGameObject()
        {
            if(_stack.Item == null) return;
            SetGameSprite();
            AdjustNumberOfItems();
            UpdateGameObjectName();
        }

        private void SetGameSprite()
        {
            _spriteRenderer.sprite = _stack.Item.InGameSprite;
        }

        private void UpdateGameObjectName()
        {
            //ItemName (5)/
            var name = _stack.Item.Name;
            var number = _stack.IsStackable ? _stack.NumberOfItems.ToString() : "ns";
            gameObject.name = $"{name} ({number})";
        }

        private void AdjustNumberOfItems()
        {
            _stack.NumberOfItems =  _stack.NumberOfItems;
        }

    }
}
