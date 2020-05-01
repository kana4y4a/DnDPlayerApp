namespace DnDLibrary.Models.Abstract
{
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;

    public abstract class AWeapon : IWeapon
    {
        public uint Id => getId();
        protected abstract uint getId();

        public byte Amount => getAmount();
        protected abstract byte getAmount();

        public string Name => getName();
        protected abstract string getName();

        public string Description => getDescription();
        protected abstract string getDescription();

        public uint Price => getPrice();
        protected abstract uint getPrice();

        public float Weight => getWeight();
        protected abstract float getWeight();

        public int NormalTrowDistance => getNormalTrowDistance();
        protected abstract int getNormalTrowDistance();

        public int MaxThrowDistance => getMaxThrowDistance();
        protected abstract int getMaxThrowDistance();

        public ushort WeaponAttributeMask => getWeaponAttributeMask();
        protected abstract ushort getWeaponAttributeMask();

        public bool IsStashable => getIsStashable();
        protected abstract bool getIsStashable();

        public byte DamageDiceMultiplier => getDamageDiceMultiplier();
        protected abstract byte getDamageDiceMultiplier();

        public ItemType ItemType => getItemType();
        protected abstract ItemType getItemType();

        public WeaponType WeaponType => getWeaponType();
        protected abstract WeaponType getWeaponType();

        public WeaponGroupType WeaponGroupType => getWeaponGroupType();
        protected abstract WeaponGroupType getWeaponGroupType();

        public DamageType DamageType => getDamageType();
        protected abstract DamageType getDamageType();

        public DamageGroupType DamageGroupType => getDamageGroupType();
        protected abstract DamageGroupType getDamageGroupType();

        public ICube DamageDice => getDamageDice();
        protected abstract ICube getDamageDice();

        public ICube VersatileDamageDice => getVersatileDamageDice();
        protected abstract ICube getVersatileDamageDice();
    }
}
