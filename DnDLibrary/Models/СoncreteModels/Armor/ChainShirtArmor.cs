namespace DnDLibrary.Models.СoncreteModels.Armor
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class ChainShirtArmor : BaseArmorModel
    {
        public ChainShirtArmor() : base()
        {
            _id = 5;
            _amount = 1;
            _name = LanguageHelper.GetString(_id);
            _description = LanguageHelper.GetString(_id);

            _armorGroupType = ArmorGroupType.Medium;
            _armorType = ArmorType.ChainShirt;

            _price = (uint)(50u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _armorClass = 13;
            _weight = 20.0f;
        }
    }
}
