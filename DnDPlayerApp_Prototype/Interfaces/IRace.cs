namespace DnDPlayerApp_Prototype.Interfaces
{
    using System.Collections.Generic;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public interface IRace
    {
        int Age { get; }
        int Size { get; }
        int Speed { get; }
        void SetSubRace(IRace subRace);
        int GetAbilityScoreIncrease(Stat stat);
        int GetSkillScoreIncrease(Skill skill);

        IRace SubRace { get; }
        IAlignment Alignment { get; }

        IEnumerable<IWeapon> CombatTraining { get; }
    }
}
