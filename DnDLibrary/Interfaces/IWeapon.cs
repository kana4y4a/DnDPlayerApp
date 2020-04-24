namespace DnDLibrary.Interfaces
{
    using System;

    public interface IWeapon
    {
        string Name { get; }
        string Description { get; }
        int Price { get; }
        byte Weight { get; }
        int NormalTrowDistance { get; }
        int MaxThrowDistance { get; }
        
        UInt16 WeaponTypeMask { get; }

        ICube DamageDice { get; }
    }
}
