namespace DnDLibrary.Models.BaseModules
{
    using System;
    using DnDLibrary.Models.Abstract;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Dictionaries;

    public class BaseArmorModel : AArmor
    {
        protected UInt32 _id;
        protected string _name;
        protected string _description;
        protected byte _armorClass;
        protected byte _weight;
        protected bool _stealthAffected;
        protected byte _streingthRequire;
        protected int _price;
        protected byte _amount;
        protected ArmorGroupType _armorGroupType;
        protected ArmorType _armorType;
        protected ItemType _itemType;

        protected override UInt32 getId() => _id;

        protected override string getName() => _name;

        protected override string getDescription() => _description;

        protected override byte getArmorClass() => _armorClass;

        protected override byte getWeight() => _weight;

        protected override bool getStealthAffected() => _stealthAffected;

        protected override byte getStreingthRequire() => _streingthRequire;

        protected override int getPrice() => _price;

        protected override byte getAmount() => _amount;

        protected override ArmorGroupType getArmorGroupType() => _armorGroupType;

        protected override ArmorType getArmorType() => _armorType;

        protected override ItemType getItemType() => _itemType;

        protected BaseArmorModel()
        {
            _id = 0;
            _amount = 0;
            _name = string.Empty;
            _description = string.Empty;
            _armorClass = 0;
            _weight = 0;
            _stealthAffected = false;
            _streingthRequire = 0;
            _price = 0;
            _armorGroupType = ArmorGroupType.None;
            _armorType = ArmorType.None;
            _itemType = ItemType.None;
        }
    }
}
