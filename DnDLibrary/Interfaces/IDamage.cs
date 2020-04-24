namespace DnDLibrary.Interfaces
{
    using DnDLibrary.Models.Emuns;

    interface IDamage
    {
        int Amount { get; }
        byte DurationCount { get; }
        DamageType DamageType { get; }
        SpellDurationType DurationType { get; }
    }
}
