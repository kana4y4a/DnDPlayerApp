namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Shortbow : BaseWeaponModel
    {
        public Shortbow() : base()
        {
            _id = 23;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleRangedWeapon;
            _weaponType = WeaponType.Shortbow;

            _price = (uint)(25u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageType = DamageType.Piercing;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Ammunition &
                                            WeaponAttributeType.TwoHanded);
            _normalTrowDistance = 80;
            _maxTrowDistance = 320;

            _amount = 1;
        }
    }
}
