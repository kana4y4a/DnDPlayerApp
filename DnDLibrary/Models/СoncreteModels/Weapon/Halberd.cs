namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Halberd : BaseWeaponModel
    {
        public Halberd() : base()
        {
            _id = 30;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.Halberd;

            _price = (uint)(20u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d10();
            _damageType = DamageType.Slashing;
            _weight = 6.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Heavy &
                                            WeaponAttributeType.Reach &
                                            WeaponAttributeType.TwoHanded);

            _amount = 1;
        }
    }
}
