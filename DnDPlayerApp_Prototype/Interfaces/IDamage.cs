namespace DnDPlayerApp_Prototype.Interfaces
{
    using DnDPlayerApp_Prototype.Models.Emuns;

    interface IDamage
    {
        int Amount { get; }
        byte DurationCount { get; }
        DamageType DamageType { get; }
        SpellDurationType DurationType { get; }
    }
}
