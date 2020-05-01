namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Lance : BaseWeaponModel
    {
        public Lance() : base()
        {
            _id = 31;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.Lance;

            _price = (uint)(10u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d12();
            _damageType = DamageType.Piercing;
            _weight = 6.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Reach &
                                            WeaponAttributeType.Special);

            _amount = 1;
        }
    }
}
