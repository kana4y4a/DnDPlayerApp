namespace DnDPlayerApp_Prototype.Interfaces
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
        ICube HitPointDice { get; }
        bool[,] DeathSaves { get; }
        IList<IWeapon> Weapons { get; }
        IList<IArmor> Armors { get; }
        IClass CharacterClass { get; }
        IRace CharacterRace { get; }
        string CharacterName { get; }
        int Level { get; }
        int CurrentExp { get; }
    }
}
