namespace DnDLibrary.Models.BaseModules
{
    using DnDLibrary.Models.Abstract;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Interfaces;
    using System.Collections.Generic;

    public class BaseRaceModule : ARace
    {
        protected int _age;
        protected int _size;
        protected int _speed;
        protected IRace _subRace;
        protected IAlignment _alignment;
        protected IEnumerable<IWeapon> _combatTraining;

        protected override int getAge() => _age;
        protected override int getSize() => _size;
        protected override int getSpeed() => _speed;
        protected override IRace getSubRace() => _subRace;
        protected override IAlignment getAlignment() => _alignment;
        protected override IEnumerable<IWeapon> getCombatTraining() => _combatTraining;

        protected BaseRaceModule()
        {
            _age = 0;
            _size = 0;
            _speed = 0;
            _subRace = null;
            _alignment = null;
            _combatTraining = new List<IWeapon>();
        }

        public override int GetSkillScoreIncrease(Skill skill)
        {
            return getRaceSkillScoreIncrease(skill) + getSubRaceSkillScoreIncrease(skill);
        }

        public override int GetAbilityScoreIncrease(Stat stat)
        {
            return getRaceAbilityScoreIncrease(stat) + getSubRaceAbilityScoreIncrease(stat);
        }

        protected virtual int getRaceSkillScoreIncrease(Skill skill)
        {
            return 0;
        }
        protected virtual int getSubRaceSkillScoreIncrease(Skill skill)
        {
            return 0;
        }

        protected virtual int getRaceAbilityScoreIncrease(Stat stat)
        {
            return 0;
        }
        protected virtual int getSubRaceAbilityScoreIncrease(Stat stat)
        {
            return 0;
        }

        public override void SetSubRace(IRace subRace)
        {
            _subRace = subRace;
        }
    }
}