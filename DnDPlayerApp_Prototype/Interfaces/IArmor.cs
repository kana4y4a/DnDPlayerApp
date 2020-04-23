namespace DnDPlayerApp_Prototype.Interfaces
{
    using DnDPlayerApp_Prototype.Models.Emuns;

    public interface IArmor
    {
        string Name { get; }
        string Description { get; }
        byte ArmorClass { get; }
        byte Weight { get; }
        bool StealthAffected { get; }
        byte StrengthRequire { get; }
        int Cost { get; }

        ArmorGroupType ArmorGroupType { get; }
    }
}
