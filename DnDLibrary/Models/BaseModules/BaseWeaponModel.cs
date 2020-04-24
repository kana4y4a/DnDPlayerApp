namespace DnDLibrary.Models.BaseModules
{
    using System;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Abstract;

    public class BaseWeaponModel : AWeapon
    {
        protected string _name;
        protected string _description;
        protected int _price;
        protected byte _weight;
        protected int _normalTrowDistance;
        protected int _maxTrowDistance;
        protected UInt16 _weaponTypeMask;
        protected ICube _damageDice;

        protected override string getName() => _name;

        protected override string getDescription() => _description;

        protected override int getPrice() => _price;

        protected override byte getWeight() => _weight;

        protected override int getNormalTrowDistance() => _normalTrowDistance;

        protected override int getMaxThrowDistance() => _maxTrowDistance;

        protected override ushort getWeaponTypeMask() => _weaponTypeMask;

        protected override ICube getDamageDice() => _damageDice;
    }
}
