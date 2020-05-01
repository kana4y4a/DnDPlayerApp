namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class GreatSword : BaseWeaponModel
    {
        public GreatSword() : base()
        {
            _id = 29;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.GreatSword;

            _price = (uint)(50u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageDiceMultiplaier = 2;
            _damageType = DamageType.Slashing;
            _weight = 6.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Heavy &
                                            WeaponAttributeType.TwoHanded);

            _amount = 1;
        }
    }
}
