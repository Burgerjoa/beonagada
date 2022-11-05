namespace ItemSysytem
{
    public class inventorySlotSataeChangedArgs
    {
        public ItemStack NewState { get; }
        public bool Active { get; }

        public inventorySlotSataeChangedArgs(ItemStack newState, bool active)
        {
            NewState = newState;
            Active = active;
        }
    }
}