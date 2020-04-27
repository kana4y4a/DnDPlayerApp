namespace DnDLibrary.Models.BaseModules
{
    using System;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Abstract;
    using DnDLibrary.Models.Emuns;

    public class BaseWeaponModel : AWeapon
    {
        protected UInt32 _id;
        protected string _name;
        protected string _description;
        protected int _price;
        protected byte _weight;
        protected int _normalTrowDistance;
        protected int _maxTrowDistance;
        protected UInt16 _weaponTypeMask;
        protected byte _amount;
        protected ItemType _itemType;
        protected ICube _damageDice;

        protected override UInt32 getId() => _id;

        protected override string getName() => _name;

        protected override string getDescription() => _description;

        protected override int getPrice() => _price;

        protected override byte getWeight() => _weight;

        protected override int getNormalTrowDistance() => _normalTrowDistance;

        protected override int getMaxThrowDistance() => _maxTrowDistance;

        protected override ushort getWeaponTypeMask() => _weaponTypeMask;
        protected override byte getAmount() => _amount;

        protected override ItemType getItemType() => _itemType;

        protected override ICube getDamageDice() => _damageDice;

        protected BaseWeaponModel()
        {
            _id = 0;
            _name = string.Empty;
            _description = string.Empty;
            _price = 0;
            _weight = 0;
            _normalTrowDistance = 0;
            _maxTrowDistance = 0;
            _weaponTypeMask = 0;
            _amount = 0;
            _itemType = ItemType.Weapon;
            _damageDice = null;
        }
    }
}
