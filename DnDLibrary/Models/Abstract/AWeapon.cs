namespace DnDLibrary.Models.Abstract
{
    using DnDLibrary.Interfaces;
    using System;

    public abstract class AWeapon : IWeapon
    {
        public string Name => getName();
        protected abstract string getName();

        public string Description => getDescription();
        protected abstract string getDescription();

        public int Price => getPrice();
        protected abstract int getPrice();

        public byte Weight => getWeight();
        protected abstract byte getWeight();

        public int NormalTrowDistance => getNormalTrowDistance();
        protected abstract int getNormalTrowDistance();

        public int MaxThrowDistance => getMaxThrowDistance();
        protected abstract int getMaxThrowDistance();

        public UInt16 WeaponTypeMask => getWeaponTypeMask();
        protected abstract UInt16 getWeaponTypeMask();

        public ICube DamageDice => getDamageDice();
        protected abstract ICube getDamageDice();
    }
}
