using System;
using UnityEngine;

namespace ItemSysytem
{
    [Serializable]
    public class InventorySlot
    {
        public event EventHandler<inventorySlotSataeChangedArgs> StateChanged; 
        
        [SerializeField] private ItemStack _state;

        private bool _active;

        public ItemStack State
        {
            get => _state;
            set
            {
                _state = value;
                NotifyAboutStateChange();
            }
        }

        public bool Active
        {
            get => _active;
            set
            {
                _active = value;
                NotifyAboutStateChange();
            }
        }

        public int NumberOfItems
        {
            get => _state.NumberOfItems;
            set
            {
                _state.NumberOfItems = value;
                NotifyAboutStateChange();
            }
        }

        public bool HasItem => _state?.Item != null;
        public ItemDefinition Item => _state?.Item;

        public void Clear()
        {
            State = null;
            
        }

        private void NotifyAboutStateChange()
        {
            StateChanged?.Invoke(this, new inventorySlotSataeChangedArgs(_state, _active));
        }

    }
}
