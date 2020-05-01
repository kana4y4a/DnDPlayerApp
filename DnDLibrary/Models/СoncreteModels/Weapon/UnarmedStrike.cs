namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Models.Cubes;

    public class UnarmedStrike : BaseWeaponModel
    {
        public UnarmedStrike() : base()
        {
            _id = 20;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleMeleeWeapon;
            _weaponType = WeaponType.UnarmedStrike;

            _damageDice = new Cube_1d6();
            _damageType = DamageType.Bludgeoning;

            _amount = 1;
        }
    }
}
