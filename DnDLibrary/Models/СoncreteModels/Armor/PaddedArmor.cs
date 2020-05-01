namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class PaddedArmor : BaseArmorModel
    {
        public PaddedArmor() : base()
        {
            _id = 1;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Light;
            _armorType = ArmorType.Padded;

            _price = (uint)(5u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 11;
            _stealthAffected = true;
            _weight = 8.0f;
        }
    }
}
