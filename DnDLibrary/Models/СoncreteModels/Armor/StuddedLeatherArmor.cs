namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class StuddedLeatherArmor : BaseArmorModel
    {
        public StuddedLeatherArmor() : base()
        {
            _id = 3;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Light;
            _armorType = ArmorType.StuddedLeather;

            _price = (uint)(45u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 12;
            _weight = 13.0f;
        }
    }
}
