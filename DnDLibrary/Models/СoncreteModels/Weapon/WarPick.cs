namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class WarPick : BaseWeaponModel
    {
        public WarPick() : base()
        {
            _id = 40;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.WarPick;

            _price = (uint)(5u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d8();
            _damageType = DamageType.Piercing;
            _weight = 2.0f;

            _amount = 1;
        }
    }
}
