namespace DnDLibrary.Interfaces
{
    using DnDLibrary.Models.Emuns;

    public interface IWeapon : IItem
    {
        byte DamageDiceMultiplier { get; }
        int NormalTrowDistance { get; }
        int MaxThrowDistance { get; }
        ushort WeaponAttributeMask { get; }

        WeaponType WeaponType { get; }
        WeaponGroupType WeaponGroupType { get; }
        DamageType DamageType { get; }
        DamageGroupType DamageGroupType { get; }

        ICube DamageDice { get; }
        ICube VersatileDamageDice { get; }
    }
}
