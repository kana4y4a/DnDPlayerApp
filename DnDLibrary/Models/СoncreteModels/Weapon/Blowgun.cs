namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Blowgun : BaseWeaponModel
    {
        public Blowgun() : base()
        {
            _id = 43;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialRangedWeapon;
            _weaponType = WeaponType.Blowgun;

            _price = (uint)(10u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d1();
            _damageType = DamageType.Piercing;
            _weight = 1.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Ammunition &
                                            WeaponAttributeType.Loading);
            _normalTrowDistance = 20;
            _maxTrowDistance = 100;

            _amount = 1;
        }
    }
}
