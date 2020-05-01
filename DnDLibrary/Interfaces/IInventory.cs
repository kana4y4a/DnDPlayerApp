namespace DnDLibrary.Interfaces
{
    using System.Collections.Generic;

    public interface IInventory
    {
        byte UsedSlots { get; }
        byte MaxSlots { get; }
        byte UsedBagSlots { get; }
        byte MaxBagSlots { get; }
        IEnumerable<IItem> Items { get; }
    }
}
