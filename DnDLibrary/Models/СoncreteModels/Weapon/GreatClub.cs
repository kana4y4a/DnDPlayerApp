namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class GreatClub : BaseWeaponModel
    {
        public GreatClub() : base()
        {
            _id = 15;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleMeleeWeapon;
            _weaponType = WeaponType.GreatClub;

            _price = (uint)(2u * CoinExchange.Table[(int)CoinsType.Silver].Coef_cp);
            _damageDice = new Cube_1d8();
            _damageType = DamageType.Bludgeoning;
            _weight = 10.0f;
            _weaponAttributeMask = (ushort)WeaponAttributeType.TwoHanded;

            _amount = 1;
        }
    }
}
