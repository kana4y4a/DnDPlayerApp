namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Sling : BaseWeaponModel
    {
        public Sling() : base()
        {
            _id = 24;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleRangedWeapon;
            _weaponType = WeaponType.Sling;

            _price = (uint)(1u * CoinExchange.Table[(int)CoinsType.Silver].Coef_cp);
            _damageDice = new Cube_1d4();
            _damageType = DamageType.Bludgeoning;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Ammunition);
            _normalTrowDistance = 30;
            _maxTrowDistance = 120;

            _amount = 1;
        }
    }
}
