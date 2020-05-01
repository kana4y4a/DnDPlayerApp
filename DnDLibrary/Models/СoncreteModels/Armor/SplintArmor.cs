namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class SplintArmor : BaseArmorModel
    {
        public SplintArmor() : base()
        {
            _id = 11;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Heavy;
            _armorType = ArmorType.Splint;

            _price = (uint)(200u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 17;
            _streingthRequire = 15;
            _stealthAffected = true;
            _weight = 60.0f;
        }
    }
}
