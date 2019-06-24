namespace DnDPlayerApp_Prototype.Interfaces
{
    using System.Collections.Generic;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public interface IRace
    {
        IRace SubRace { get; }

        int Age { get; }
        IAlignment Alignment { get; }
        int Size { get; }
        int Speed { get; }
        IList<IWeapon> CombatTraining { get;}

        void SetSubRace(IRace subRace);
        int GetAbilityScoreIncrease(Stat stat);
        int GetSkillScoreIncrease(Skill skill);
    }
}
