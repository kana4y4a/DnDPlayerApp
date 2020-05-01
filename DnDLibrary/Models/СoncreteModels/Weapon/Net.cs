namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;

    public class Net : BaseWeaponModel
    {
        public Net() : base()
        {
            _id = 47;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialRangedWeapon;
            _weaponType = WeaponType.Net;

            _price = (uint)(1u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _weight = 3.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Special &
                                            WeaponAttributeType.Thrown);
            _normalTrowDistance = 5;
            _maxTrowDistance = 15;

            _amount = 1;
        }
    }
}
