namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.Dictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;

    public class PaddedArmor : BaseArmorModel
    {
        public PaddedArmor() : base()
        {
            _name = LanguageHelper.GetString(0);
            _description = LanguageHelper.GetString(0);
            _armorClass = 11;
            _weight = 8;
            _stealthAffected = true;
            _streingthRequire = 0;
            _price = 5;
            _armorGroupType = ArmorGroupType.Light;
            _armorType = ArmorType.Padded;
        }
    }
}
