namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class BattleAxe : BaseWeaponModel
    {
        public BattleAxe() : base()
        {
            _id = 25;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.BattleAxe;

            _price = (uint)(10u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d8();
            _damageType = DamageType.Slashing;
            _weight = 4.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Versatile);
            _versatileDamageDice = new Cube_1d10();

            _amount = 1;
        }
    }
}
