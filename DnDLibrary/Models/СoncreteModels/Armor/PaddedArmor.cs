namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using System;
    using DnDLibrary.Dictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;

    public class PaddedArmor : BaseArmorModel
    {
        public PaddedArmor(UInt32 id = 0) : base()
        {
            _id = id;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);
            _armorClass = 11;
            _weight = 8;
            _stealthAffected = true;
            _streingthRequire = 0;
            _price = 5;
            _armorGroupType = ArmorGroupType.Light;
            _armorType = ArmorType.Padded;
            _itemType = ItemType.Armor;
        }
    }
}
