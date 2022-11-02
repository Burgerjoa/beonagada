using System;
using UnityEngine;

namespace ItemSysytem
{
    [Serializable]
    public class ItemStack
    {
        [SerializeField] private ItemDefinition _item;
        [SerializeField] private int _numberOfItmes;

        public bool IsStackable =>_item != null &&  _item.IsStackable;
        public ItemDefinition Item => _item;

        public int NumberOfItems
        {
            get => _numberOfItmes;
            set
            {
                value = value < 0 ? 0 : value;
                _numberOfItmes = IsStackable ? value : 1;
                
            }
        }

        public ItemStack(ItemDefinition item, int numberOfItmes)
        {
            _item = item;
            NumberOfItems = numberOfItmes;


        }

        public ItemStack()
        {
            
        }
    }
}
