namespace DnDLibrary.Models.Abstract
{
    using System;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;

    public abstract class AArmor : IArmor
    {
        public uint Id => getId();
        protected abstract uint getId();

        public byte Amount => getAmount();
        protected abstract byte getAmount();

        public string Name => getName();
        protected abstract string getName();

        public string Description => getDescription();
        protected abstract string getDescription();

        public byte ArmorClass => getArmorClass();
        protected abstract byte getArmorClass();

        public float Weight => getWeight();
        protected abstract float getWeight();

        public bool StealthAffected => getStealthAffected();
        protected abstract bool getStealthAffected();

        public byte StreingthRequire => getStreingthRequire();
        protected abstract byte getStreingthRequire();

        public uint Price => getPrice();
        protected abstract uint getPrice();

        public bool IsStashable => getIsStashable();
        protected abstract bool getIsStashable();

        public ArmorGroupType ArmorGroupType => getArmorGroupType();
        protected abstract ArmorGroupType getArmorGroupType();

        public ArmorType ArmorType => getArmorType();
        protected abstract ArmorType getArmorType();

        public ItemType ItemType => getItemType();

        protected abstract ItemType getItemType();
    }
}
