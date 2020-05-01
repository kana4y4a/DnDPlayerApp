namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class ScaleMailArmor : BaseArmorModel
    {
        public ScaleMailArmor() : base()
        {
            _id = 6;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Medium;
            _armorType = ArmorType.ScaleMail;

            _price = (uint)(50u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 14;
            _stealthAffected = true;
            _weight = 45.0f;
        }
    }
}
