namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class CrossbowHand : BaseWeaponModel
    {
        public CrossbowHand() : base()
        {
            _id = 44;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialRangedWeapon;
            _weaponType = WeaponType.CrossbowHand;

            _price = (uint)(75u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageType = DamageType.Piercing;
            _weight = 3.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Ammunition &
                                            WeaponAttributeType.Light &
                                            WeaponAttributeType.Loading);
            _normalTrowDistance = 30;
            _maxTrowDistance = 120;

            _amount = 1;
        }
    }
}
