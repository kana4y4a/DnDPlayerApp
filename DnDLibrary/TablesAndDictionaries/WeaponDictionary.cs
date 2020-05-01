namespace DnDLibrary.TablesAndDictionaries
{
    using System.Collections.Generic;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.СoncreteModels.Weapon;

    public static class WeaponDictionary
    {
        public static readonly IDictionary<WeaponType, IWeapon> Table = new Dictionary<WeaponType, IWeapon>
        {
            { WeaponType.None, null },
            // Simple melee weapon
            { WeaponType.Club, new Club() },
            { WeaponType.Dagger, new Dagger() },
            { WeaponType.GreatClub, new GreatClub() },
            { WeaponType.HandAxe, new HandAxe() },
            { WeaponType.Javelin, new Javelin() },
            { WeaponType.LightHammer, new LightHammer() },
            { WeaponType.Mace, new Mace() },
            { WeaponType.QuarterStaff, new QuarterStaff() },
            { WeaponType.Sickle, new Sickle() },
            { WeaponType.Spear, new Spear() },
            { WeaponType.UnarmedStrike, new UnarmedStrike() },
            // Simple range weapon
            { WeaponType.CrossbowLight, new CrossbowLight() },
            { WeaponType.Dart, new Dart() },
            { WeaponType.Shortbow, new Shortbow() },
            { WeaponType.Sling, new Sling() },
            // Martiral melee weapon
            { WeaponType.BattleAxe, new BattleAxe() },
            { WeaponType.Flail, new Flail() },
            { WeaponType.Glaive, new Glaive() },
            { WeaponType.GreatAxe, new GreatAxe() },
            { WeaponType.GreatSword, new GreatSword() },
            { WeaponType.Halberd, new Halberd() },
            { WeaponType.Lance, new Lance() },
            { WeaponType.LongSword, new LongSword() },
            { WeaponType.Maul, new Maul() },
            { WeaponType.Morningstar, new Morningstar() },
            { WeaponType.Pike, new Pike() },
            { WeaponType.Rapier, new Rapier() },
            { WeaponType.Scimitar, new Scimitar() },
            { WeaponType.ShortSword, new ShortSword() },
            { WeaponType.Trident, new Trident() },
            { WeaponType.WarPick, new WarPick() },
            { WeaponType.WarHammer, new WarHammer() },
            { WeaponType.Whip, new Whip() },
            // Martiral range weapon
            { WeaponType.Blowgun, new Blowgun() },
            { WeaponType.CrossbowHand, new CrossbowHand() },
            { WeaponType.CrossbowHeavy, new CrossbowHeavy() },
            { WeaponType.Longbow, new Longbow() },
            { WeaponType.Net, new Net() }
        };
    }
}
