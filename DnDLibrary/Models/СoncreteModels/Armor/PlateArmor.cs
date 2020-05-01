namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class PlateArmor : BaseArmorModel
    {
        public PlateArmor() : base()
        {
            _id = 12;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Heavy;
            _armorType = ArmorType.Plate;

            _price = (uint)(1500u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 18;
            _streingthRequire = 15;
            _stealthAffected = true;
            _weight = 65.0f;
        }
    }
}
