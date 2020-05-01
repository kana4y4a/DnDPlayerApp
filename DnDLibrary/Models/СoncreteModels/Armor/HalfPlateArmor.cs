namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class HalfPlateArmor : BaseArmorModel
    {
        public HalfPlateArmor() : base()
        {
            _id = 8;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Medium;
            _armorType = ArmorType.HalfPlate;

            _price = (uint)(750u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 15;
            _stealthAffected = true;
            _weight = 40.0f;
        }
    }
}
