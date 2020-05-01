namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Sickle : BaseWeaponModel
    {
        public Sickle() : base()
        {
            _id = 19;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleMeleeWeapon;
            _weaponType = WeaponType.Sickle;

            _price = (uint)(1u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d4();
            _damageType = DamageType.Slashing;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)WeaponAttributeType.Light;

            _amount = 1;
        }
    }
}
