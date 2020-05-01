namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Pike : BaseWeaponModel
    {
        public Pike() : base()
        {
            _id = 35;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.Pike;

            _price = (uint)(5u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d10();
            _damageType = DamageType.Piercing;
            _weight = 18.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Heavy &
                                            WeaponAttributeType.Reach &
                                            WeaponAttributeType.TwoHanded);

            _amount = 1;
        }
    }
}
