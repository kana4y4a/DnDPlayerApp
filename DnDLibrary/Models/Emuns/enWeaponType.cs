namespace DnDLibrary.Models.Emuns
{
    public enum WeaponType
    {
        None,
        // Simple melee weapon
        Club,
        Dagger,
        GreatClub,
        HandAxe,
        Javelin,
        LightHammer,
        Mace,
        QuarterStaff,
        Sickle,
        Spear,
        UnarmedStrike,
        // Simple range weapon
        CrossbowLight,
        Dart,
        Shortbow,
        Sling,
        // Martiral melee weapon
        BattleAxe,
        Flail,
        Glaive,
        GreatAxe,
        GreatSword,
        Halberd,
        Lance,
        LongSword,
        Maul,
        Morningstar,
        Pike,
        Rapier,
        Scimitar,
        ShortSword,
        Trident,
        WarPick,
        WarHammer,
        Whip,
        // Martiral range weapon
        Blowgun,
        CrossbowHand,
        CrossbowHeavy,
        Longbow,
        Net
    }

    public enum WeaponGroupType
    {
        None,
        SimpleMeleeWeapon,
        SimpleRangedWeapon,
        MartialMeleeWeapon,
        MartialRangedWeapon
    }

    public enum WeaponAttributeType : ushort
    {
        None = 0x0000,
        Ammunition = 0x0001,
        Finesse = 0x0002,
        Heavy = 0x0004,
        Light = 0x0008,
        Loading = 0x0010,
        Range = 0x0020,
        Reach = 0x0040,
        Special = 0x0080,
        Thrown = 0x0100,
        TwoHanded = 0x0200,
        Versatile = 0x0400,
        Improvised = 0x0800,
        Silvered = 0x1000
    }
}