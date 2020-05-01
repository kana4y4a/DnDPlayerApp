﻿namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class LightHammer : BaseWeaponModel
    {
        public LightHammer() : base()
        {
            _id = 18;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.SimpleMeleeWeapon;
            _weaponType = WeaponType.LightHammer;

            _price = (uint)(2u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d4();
            _damageType = DamageType.Bludgeoning;
            _weight = 2.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Light &
                                            WeaponAttributeType.Thrown);
            _normalTrowDistance = 20;
            _maxTrowDistance = 60;

            _amount = 1;
        }
    }
}
