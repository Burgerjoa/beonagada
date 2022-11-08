using System;
using UnityEngine;

namespace ItemSysytem
{
    public class ItemCollisionHandler : MonoBehaviour
    {
        
        private Inventory _inventory;

        private void Awake()
        {
            _inventory = GetComponentInParent<Inventory>();
        }

        public void GetItem()
        {
            GameObject aa = GameObject.FindWithTag("Items");

            Debug.Log(aa);
            if (!aa.TryGetComponent<GameItem>(out var gameItem)) return;

            _inventory.AddItem(gameItem.Pick());
            
        }
    }
}
