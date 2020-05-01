namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class RingMailArmor : BaseArmorModel
    {
        public RingMailArmor() : base()
        {
            _id = 9;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Heavy;
            _armorType = ArmorType.RingMail;

            _price = (uint)(30u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 14;
            _stealthAffected = true;
            _weight = 40.0f;
        }
    }
}
