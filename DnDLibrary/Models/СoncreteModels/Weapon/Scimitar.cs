﻿namespace DnDLibrary.Models.СoncreteModels.Weapon
{
    using DnDLibrary.SystemDictionaries;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Helpers.Tables;
    using DnDLibrary.Models.Cubes;

    public class Scimitar : BaseWeaponModel
    {
        public Scimitar() : base()
        {
            _id = 37;
            _name = LanguageHelper.GetString(_id); ;
            _description = LanguageHelper.GetString(_id); ;

            _weaponGroupType = WeaponGroupType.MartialMeleeWeapon;
            _weaponType = WeaponType.Scimitar;

            _price = (uint)(25u * CoinExchange.Table[(int)CoinsType.Gold].Coef_cp);
            _damageDice = new Cube_1d6();
            _damageType = DamageType.Slashing;
            _weight = 3.0f;
            _weaponAttributeMask = (ushort)(WeaponAttributeType.Finesse &
                                            WeaponAttributeType.Light);

            _amount = 1;
        }
    }
}
