namespace DnDPlayerApp_Prototype.Models.Abstract
{
    using System.Collections.Generic;
    using DnDPlayerApp_Prototype.Interfaces;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public abstract class ARace : IRace
    {
        protected IRace _subRace;
        protected int _age;
        protected IAlignment _alignment;
        protected int _size;
        protected int _speed;
        protected IEnumerable<IWeapon> _combatTraining;

        public IRace SubRace => _subRace;

        public int Age => _age;

        public IAlignment Alignment => _alignment;

        public int Size => _size;

        public int Speed => _speed;

        public IEnumerable<IWeapon> CombatTraining => _combatTraining;

        public abstract int GetSkillScoreIncrease(Skill skill);

        public abstract int GetAbilityScoreIncrease(Stat stat);

        public void SetSubRace(IRace subRace)
        {
            _subRace = subRace;
        }
    }
}
