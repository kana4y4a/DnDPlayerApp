namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class Shield : BaseArmorModel
    {
        public Shield() : base()
        {
            _id = 13;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Shield;
            _armorType = ArmorType.Shield;

            _price = (uint)(10u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 2;
            _weight = 6.0f;
        }
    }
}
