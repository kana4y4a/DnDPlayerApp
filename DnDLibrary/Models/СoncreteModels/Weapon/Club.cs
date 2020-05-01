namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Club : BaseWeaponModel
    {
        public Club() : base()
        {
            _id = 13;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleMeleeWeapon;
            _weaponType = WeaponType.Club;

            _price = (uint)(1u * CoinExchange.Table[(int)CoinsType.Silver].Coef_cp);
            _damageDice = new Cube_1d4();
            _damageType = DamageType.Bludgeoning;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)WeaponAttributeType.Light;

            _amount = 1;
        }
    }
}
