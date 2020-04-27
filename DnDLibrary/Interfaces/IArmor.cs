namespace DnDLibrary.Interfaces
{
    using DnDLibrary.Models.Emuns;

    public interface IArmor : IItem
    {
        byte ArmorClass { get; }
        byte Weight { get; }
        bool StealthAffected { get; }
        byte StreingthRequire { get; }
        int Price { get; }

        ArmorGroupType ArmorGroupType { get; }
        ArmorType ArmorType { get; }
    }
}
