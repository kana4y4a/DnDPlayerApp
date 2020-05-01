namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class ChainMailArmor : BaseArmorModel
    {
        public ChainMailArmor() : base()
        {
            _id = 10;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Heavy;
            _armorType = ArmorType.ChainMail;

            _price = (uint)(75u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 16;
            _streingthRequire = 13;
            _stealthAffected = true;
            _weight = 55.0f;
        }
    }
}
