namespace ModuleBase.OnlineClasses
{
    public class OnlineSlot
    {
        public readonly string SlotName;

        public readonly string SlotType;
        
        public OnlineSlot(string slotName, string slotType)
        {
            SlotName = slotName;
            SlotType = slotType;
        }

        public override bool Equals(object obj)
        {
            OnlineSlot slot = obj as OnlineSlot;

            if (slot == null)
            {
                return false;
            }

            return Equals(slot);
        }

        public bool Equals(OnlineSlot slot)
        {
            return SlotName == slot.SlotName && SlotType == slot.SlotType;
        }

        public override int GetHashCode()
        {
            if (string.IsNullOrWhiteSpace(SlotName) && string.IsNullOrWhiteSpace(SlotType))
            {
                return base.GetHashCode();
            }

            if (string.IsNullOrWhiteSpace(SlotName))
            {
                return SlotType.GetHashCode();
            }

            if (string.IsNullOrWhiteSpace(SlotType))
            {
                return SlotName.GetHashCode();
            }

            return SlotName.GetHashCode() ^ SlotType.GetHashCode();
        }
    }
}
