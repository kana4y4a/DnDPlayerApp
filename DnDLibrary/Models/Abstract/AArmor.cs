﻿namespace DnDLibrary.Models.Abstract
{
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;

    public abstract class AArmor : IArmor
    {
        public string Name => getName();
        protected abstract string getName();

        public string Description => getDescription();
        protected abstract string getDescription();

        public byte ArmorClass => getArmorClass();
        protected abstract byte getArmorClass();

        public byte Weight => getWeight();
        protected abstract byte getWeight();

        public bool StealthAffected => getStealthAffected();
        protected abstract bool getStealthAffected();

        public byte StreingthRequire => getStreingthRequire();
        protected abstract byte getStreingthRequire();

        public int Price => getPrice();
        protected abstract int getPrice();

        public ArmorGroupType ArmorGroupType => getArmorGroupType();
        protected abstract ArmorGroupType getArmorGroupType();

        public ArmorType ArmorType => getArmorType();
        protected abstract ArmorType getArmorType();

    }
}
