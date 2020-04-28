namespace DnDLibrary.Interfaces
{
    using System.Collections.Generic;
    using DnDLibrary.Models.Emuns;

    public interface IRace
    {
        int Age { get; }
        int Size { get; }
        int Speed { get; }
        void SetSubRace(IRace subRace);
        int GetAbilityScoreIncrease(Stat stat);
        int GetSkillScoreIncrease(Skill skill);

        RaceType RaceType { get; }

        IRace SubRace { get; }
        IAlignment Alignment { get; }

        IEnumerable<IWeapon> CombatTraining { get; }
    }
}
