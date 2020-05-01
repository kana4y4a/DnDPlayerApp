namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Dart : BaseWeaponModel
    {
        public Dart() : base()
        {
            _id = 22;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleRangedWeapon;
            _weaponType = WeaponType.Dart;

            _price = (uint)(5u * CoinExchange.Table[(int)CoinsType.Copper].Coef_cp);
            _damageDice = new Cube_1d4();
            _damageType = DamageType.Piercing;
            _weight = 0.25f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Finesse &
                                            WeaponAttributeType.Thrown);
            _normalTrowDistance = 20;
            _maxTrowDistance = 60;

            _amount = 1;
        }
    }
}
