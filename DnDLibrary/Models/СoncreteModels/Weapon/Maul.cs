namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Maul : BaseWeaponModel
    {
        public Maul() : base()
        {
            _id = 33;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.Maul;

            _price = (uint)(10u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageDiceMultiplaier = 2;
            _damageType = DamageType.Bludgeoning;
            _weight = 10.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Heavy &
                                            WeaponAttributeType.TwoHanded);

            _amount = 1;
        }
    }
}
