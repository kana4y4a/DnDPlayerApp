namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class CrossbowHeavy : BaseWeaponModel
    {
        public CrossbowHeavy() : base()
        {
            _id = 45;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialRangedWeapon;
            _weaponType = WeaponType.CrossbowHeavy;

            _price = (uint)(50u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d10();
            _damageType = DamageType.Piercing;
            _weight = 18.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Ammunition &
                                            WeaponAttributeType.Heavy &
                                            WeaponAttributeType.Loading &
                                            WeaponAttributeType.TwoHanded);
            _normalTrowDistance = 100;
            _maxTrowDistance = 400;

            _amount = 1;
        }
    }
}
