namespace DnDLibrary.Interfaces
{
    using DnDLibrary.Models.Emuns;

    public interface IItem
    {
        uint Id { get; }
        string Name { get; }
        string Description { get; }
        byte Amount { get; }
        bool IsStashable { get; }
        uint Price { get; }
        float Weight { get; }


        ItemType ItemType { get; }
    }
}
