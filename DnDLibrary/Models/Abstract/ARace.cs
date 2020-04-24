namespace DnDLibrary.Models.Abstract
{
    using System.Collections.Generic;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;

    public abstract class ARace : IRace
    {
        public IRace SubRace => getSubRace();
        protected abstract IRace getSubRace();

        public int Age => getAge();
        protected abstract int getAge();

        public IAlignment Alignment => getAlignment();
        protected abstract IAlignment getAlignment();

        public int Size => getSize();
        protected abstract int getSize();

        public int Speed => getSpeed();
        protected abstract int getSpeed();

        public IEnumerable<IWeapon> CombatTraining => getCombatTraining();
        protected abstract IEnumerable<IWeapon> getCombatTraining();

        public abstract int GetSkillScoreIncrease(Skill skill);

        public abstract int GetAbilityScoreIncrease(Stat stat);

        public abstract void SetSubRace(IRace subRace);
    }
}
