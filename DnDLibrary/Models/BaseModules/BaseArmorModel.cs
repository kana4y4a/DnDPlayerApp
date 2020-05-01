namespace DnDLibrary.Models.BaseModules
{
    using System;
    using DnDLibrary.Models.Abstract;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Dictionaries;

    public class BaseArmorModel : AArmor
    {
        protected uint _id;
        protected string _name;
        protected string _description;
        protected byte _armorClass;
        protected float _weight;
        protected bool _stealthAffected;
        protected byte _streingthRequire;
        protected uint _price;
        protected byte _amount;
        protected bool _isStashable;
        protected ArmorGroupType _armorGroupType;
        protected ArmorType _armorType;
        protected ItemType _itemType;

        protected override uint getId() => _id;

        protected override string getName() => _name;

        protected override string getDescription() => _description;

        protected override byte getArmorClass() => _armorClass;

        protected override float getWeight() => _weight;

        protected override bool getStealthAffected() => _stealthAffected;

        protected override byte getStreingthRequire() => _streingthRequire;

        protected override uint getPrice() => _price;

        protected override byte getAmount() => _amount;

        protected override bool getIsStashable() => _isStashable;

        protected override ArmorGroupType getArmorGroupType() => _armorGroupType;

        protected override ArmorType getArmorType() => _armorType;

        protected override ItemType getItemType() => _itemType;


        protected BaseArmorModel()
        {
            _name = string.Empty;
            _description = string.Empty;

            _stealthAffected = false;
            _isStashable = false;

            _id = 0;
            _amount = 0;
            _armorClass = 0;
            _weight = 0.0f;
            _streingthRequire = 0;
            _price = 0;

            _armorGroupType = ArmorGroupType.None;
            _armorType = ArmorType.None;
            _itemType = ItemType.Armor;
        }
    }
}
