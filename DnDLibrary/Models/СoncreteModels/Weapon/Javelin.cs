namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Javelin : BaseWeaponModel
    {
        public Javelin() : base()
        {
            _id = 17;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleMeleeWeapon;
            _weaponType = WeaponType.Javelin;

            _price = (uint)(5u * CoinExchange.Table[(int)CoinsType.Silver].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageType = DamageType.Piercing;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Thrown);
            _normalTrowDistance = 30;
            _maxTrowDistance = 120;

            _amount = 1;
        }
    }
}
