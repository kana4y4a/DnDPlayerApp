namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class BreastplateArmor : BaseArmorModel
    {
        public BreastplateArmor() : base()
        {
            _id = 7;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Medium;
            _armorType = ArmorType.Breastplate;

            _price = (uint)(400u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 14;
            _weight = 20.0f;
        }
    }
}
