namespace DnDLibrary.Interfaces
{
    using System;

    public interface IWeapon : IItem
    {
        int Price { get; }
        byte Weight { get; }
        int NormalTrowDistance { get; }
        int MaxThrowDistance { get; }
        
        UInt16 WeaponTypeMask { get; }

        ICube DamageDice { get; }
    }
}
