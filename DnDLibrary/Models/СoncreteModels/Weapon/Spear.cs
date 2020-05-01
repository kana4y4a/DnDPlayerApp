namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Spear : BaseWeaponModel
    {
        public Spear() : base()
        {
            _id = 19;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleMeleeWeapon;
            _weaponType = WeaponType.Spear;

            _price = (uint)(1u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageType = DamageType.Piercing;
            _weight = 3.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Thrown &
                                            WeaponAttributeType.Versatile);
            _versatileDamageDice = new Cube_1d8();
            _normalTrowDistance = 20;
            _maxTrowDistance = 60;

            _amount = 1;
        }
    }
}
