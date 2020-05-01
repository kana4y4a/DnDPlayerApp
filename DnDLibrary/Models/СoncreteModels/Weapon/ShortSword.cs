namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class ShortSword : BaseWeaponModel
    {
        public ShortSword() : base()
        {
            _id = 38;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.ShortSword;

            _price = (uint)(10u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageType = DamageType.Piercing;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Finesse &
                                            WeaponAttributeType.Light);

            _amount = 1;
        }
    }
}
