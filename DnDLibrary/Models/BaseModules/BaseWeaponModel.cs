namespace DnDLibrary.Models.BaseModules
{
    using System;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Abstract;
    using DnDLibrary.Models.Emuns;

    public class BaseWeaponModel : AWeapon
    {
        protected uint _id;
        protected string _name;
        protected string _description;
        protected uint _price;
        protected float _weight;
        protected int _normalTrowDistance;
        protected int _maxTrowDistance;
        protected ushort _weaponAttributeMask;
        protected byte _amount;
        protected bool _isStashable;
        protected byte _damageDiceMultiplaier;
        protected ItemType _itemType;
        protected WeaponType _weaponType;
        protected WeaponGroupType _weaponGroupType;
        protected DamageType _damageType;
        protected DamageGroupType _damageGroupType;
        protected ICube _damageDice;
        protected ICube _versatileDamageDice;

        protected override uint getId() => _id;

        protected override string getName() => _name;

        protected override string getDescription() => _description;

        protected override uint getPrice() => _price;

        protected override float getWeight() => _weight;

        protected override int getNormalTrowDistance() => _normalTrowDistance;

        protected override int getMaxThrowDistance() => _maxTrowDistance;

        protected override ushort getWeaponAttributeMask() => _weaponAttributeMask;
        protected override byte getAmount() => _amount;

        protected override bool getIsStashable() => _isStashable;

        protected override byte getDamageDiceMultiplier() => _damageDiceMultiplaier;

        protected override ItemType getItemType() => _itemType;

        protected override WeaponType getWeaponType() => _weaponType;

        protected override WeaponGroupType getWeaponGroupType() => _weaponGroupType;

        protected override DamageType getDamageType() => _damageType;

        protected override DamageGroupType getDamageGroupType() => _damageGroupType;

        protected override ICube getDamageDice() => _damageDice;

        protected override ICube getVersatileDamageDice() => _versatileDamageDice;

        protected BaseWeaponModel()
        {
            _name = string.Empty;
            _description = string.Empty;

            _isStashable = false;

            _id = 0;
            _price = 0;
            _weight = 0.0f;
            _normalTrowDistance = 0;
            _maxTrowDistance = 0;
            _weaponAttributeMask = (ushort)WeaponAttributeType.None;
            _amount = 0;
            _damageDiceMultiplaier = 1;

            _itemType = ItemType.Weapon;
            _weaponType = WeaponType.None;
            _weaponGroupType = WeaponGroupType.None;
            _damageType = DamageType.None;
            _damageGroupType = DamageGroupType.Physical;

            _damageDice = null;
            _versatileDamageDice = null;
        }
    }
}
