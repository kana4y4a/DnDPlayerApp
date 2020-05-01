namespace DnDLibrary.Interfaces
{
    using DnDLibrary.Models.Emuns;

    public interface IArmor : IItem
    {
        byte ArmorClass { get; }
        bool StealthAffected { get; }
        byte StreingthRequire { get; }

        ArmorGroupType ArmorGroupType { get; }
        ArmorType ArmorType { get; }
    }
}
