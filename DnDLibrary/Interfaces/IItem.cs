namespace DnDLibrary.Interfaces
{
    using System;
    using DnDLibrary.Models.Emuns;

    public interface IItem
    {
        UInt32 Id { get; }
        string Name { get; }
        string Description { get; }
        byte Amount { get; }

        ItemType ItemType { get; }
    }
}
