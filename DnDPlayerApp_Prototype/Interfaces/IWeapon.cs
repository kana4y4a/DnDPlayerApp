namespace DnDPlayerApp_Prototype.Interfaces
{
    using System;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public interface IWeapon
    {
        string Name { get; }
        string Description { get; }
        int Cost { get; }
        byte Weight { get; }

        UInt16 WeaponTypeMask { get; }

        ICube Damage { get; }
    }
}
