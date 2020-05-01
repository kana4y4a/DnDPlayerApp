namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Whip : BaseWeaponModel
    {
        public Whip() : base()
        {
            _id = 42;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.Whip;

            _price = (uint)(2u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d4();
            _damageType = DamageType.Slashing;
            _weight = 3.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Versatile &
                                            WeaponAttributeType.Reach);

            _amount = 1;
        }
    }
}
