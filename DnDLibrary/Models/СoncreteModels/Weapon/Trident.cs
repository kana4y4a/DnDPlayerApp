namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Trident : BaseWeaponModel
    {
        public Trident() : base()
        {
            _id = 39;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.Trident;

            _price = (uint)(5u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageType = DamageType.Piercing;
            _weight = 4.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Thrown &
                                            WeaponAttributeType.Versatile);
            _normalTrowDistance = 20;
            _maxTrowDistance = 60;
            _versatileDamageDice = new Cube_1d8();

            _amount = 1;
        }
    }
}
