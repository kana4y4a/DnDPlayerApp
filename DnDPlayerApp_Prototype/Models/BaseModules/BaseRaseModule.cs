namespace DnDPlayerApp_Prototype.Models.BaseModules
{
    using DnDPlayerApp_Prototype.Models.Abstract;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public class BaseRaseModule : ARace
    {
        protected BaseRaseModule()
        {
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
    }
}