namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class QuarterStaff : BaseWeaponModel
    {
        public QuarterStaff() : base()
        {
            _id = 18;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleMeleeWeapon;
            _weaponType = WeaponType.QuarterStaff;

            _price = (uint)(2u * CoinExchange.Table[(int)CoinsType.Silver].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageType = DamageType.Bludgeoning;
            _weight = 4.0f;
            _weaponAttributeMask = (ushort)WeaponAttributeType.Versatile;
            _versatileDamageDice = new Cube_1d8();

            _amount = 1;
        }
    }
}
