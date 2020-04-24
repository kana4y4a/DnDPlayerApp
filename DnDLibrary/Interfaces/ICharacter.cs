namespace DnDLibrary.Interfaces
{
    using System.Collections.Generic;

    public interface ICharacter
    {
        int Perception { get; }
        int Inspiration { get; }
        int ProficiencyBonus { get; }
        int Initiative { get; }
        int Speed { get; }
        int HitPoints { get; }
        int TemporaryHitPoints { get; }
        string CharacterName { get; }
        int Level { get; }
        int CurrentExp { get; }

        ICube HitPointDice { get; }
        IClass CharacterClass { get; }
        IRace CharacterRace { get; }

        bool[,] DeathSaves { get; }
        IEnumerable<IWeapon> Weapons { get; }
        IEnumerable<IArmor> Armors { get; }
    }
}
