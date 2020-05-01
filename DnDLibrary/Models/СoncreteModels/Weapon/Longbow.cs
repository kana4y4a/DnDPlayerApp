namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Longbow : BaseWeaponModel
    {
        public Longbow() : base()
        {
            _id = 46;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialRangedWeapon;
            _weaponType = WeaponType.Longbow;

            _price = (uint)(50u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d8();
            _damageType = DamageType.Piercing;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Ammunition &
                                            WeaponAttributeType.Heavy &
                                            WeaponAttributeType.TwoHanded);
            _normalTrowDistance = 150;
            _maxTrowDistance = 600;

            _amount = 1;
        }
    }
}
