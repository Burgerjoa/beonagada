/*using System;
using UnityEngine;

namespace ItemSysytem
{
    [Serializable]
    public class InventorySlot
    {
        public event EventHandler<inventorySlotSataeChangedArgs> stateChanged; 
        
        [SerializeField] private ItemStack _state;

        private bool _active;

        private void NotifyAboutStateChange()
        {
            CullingGroup.StateChanged?.Invoke(this, new inventorySlotSataeChangedArgs(_state, _active));
        }

    }
}*/
