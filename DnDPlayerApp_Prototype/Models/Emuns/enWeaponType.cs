﻿namespace DnDPlayerApp_Prototype.Models.Emuns
{
    public enum WeaponGropType : System.UInt16
    {
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
