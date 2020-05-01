namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Rapier : BaseWeaponModel
    {
        public Rapier() : base()
        {
            _id = 36;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.Rapier;

            _price = (uint)(25u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d8();
            _damageType = DamageType.Piercing;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Finesse);

            _amount = 1;
        }
    }
}
