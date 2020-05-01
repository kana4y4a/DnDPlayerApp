namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class LeatherArmor : BaseArmorModel
    {
        public LeatherArmor() : base()
        {
            _id = 2;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Light;
            _armorType = ArmorType.Leather;

            _price = (uint)(10u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 11;
            _weight = 10.0f;
        }
    }
}
