namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class CrossbowLight : BaseWeaponModel
    {
        public CrossbowLight() : base()
        {
            _id = 21;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleRangedWeapon;
            _weaponType = WeaponType.CrossbowLight;

            _price = (uint)(25u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d8();
            _damageType = DamageType.Piercing;
            _weight = 5.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Ammunition &
                                            WeaponAttributeType.Loading &
                                            WeaponAttributeType.TwoHanded);
            _normalTrowDistance = 80;
            _maxTrowDistance = 320;

            _amount = 1;
        }
    }
}
