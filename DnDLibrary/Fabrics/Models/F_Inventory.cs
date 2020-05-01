using System;
using System.Collections.Generic;
using DnDLibrary.Interfaces;

namespace DnDLibrary.Fabrics.Models
{
    public class F_Inventory
    {
        public byte UsedSlots { get; set; }
        public byte MaxSlots { get; set; }
        public byte UsedBagSlots { get; set; }
        public byte MaxBagSlots { get; set; }
        public IEnumerable<IItem> Items { get; set; }

        public F_Inventory()
        {
            Items = new List<IItem>();
        }

        internal F_Inventory(IInventory inventory)
        {
            Setup(inventory);
        }

        internal void Setup(IInventory inventory)
        {
            UsedSlots = inventory.UsedSlots;
            MaxSlots = inventory.MaxSlots;
            UsedBagSlots = inventory.UsedBagSlots;
            MaxBagSlots = inventory.MaxBagSlots;
            Items = inventory.Items;
        }
    }
}
