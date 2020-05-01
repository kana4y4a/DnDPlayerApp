namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class GreatAxe : BaseWeaponModel
    {
        public GreatAxe() : base()
        {
            _id = 28;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.GreatAxe;

            _price = (uint)(30u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d12();
            _damageType = DamageType.Slashing;
            _weight = 7.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Heavy &
                                            WeaponAttributeType.TwoHanded);

            _amount = 1;
        }
    }
}
