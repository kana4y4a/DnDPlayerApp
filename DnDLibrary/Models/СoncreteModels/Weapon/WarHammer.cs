namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class WarHammer : BaseWeaponModel
    {
        public WarHammer() : base()
        {
            _id = 41;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.WarHammer;

            _price = (uint)(15u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d8();
            _damageType = DamageType.Bludgeoning;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Versatile);
            _versatileDamageDice = new Cube_1d10();

            _amount = 1;
        }
    }
}
