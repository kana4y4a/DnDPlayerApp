namespace DnDLibrary.Fabrics.Models
{
    using System.Collections.Generic;
    using DnDLibrary.Helpers;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.СoncreteModels.Races;
    using DnDLibrary.Models.СoncreteModels.SubRaces;

    public class F_Character
    {
        public int PassivePerception { get; set; }
        public int Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int HitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int CurrentExp { get; set; }
        public ICube HitPointDice { get; set; }
        public IClass Class { get; set; }
        public RaceType Race { get; set; }
        public RaceType SubRace { get; set; }
        public IEnumerable<IWeapon> Weapons { get; set; }
        public IEnumerable<IArmor> Armors { get; set; }

        public F_Character()
        {
        }

        internal F_Character(ICharacter character)
        {
            Setup(character);
        }

        internal void Setup(ICharacter character)
        {
            PassivePerception = character.PassivePerception;
            Inspiration = character.Inspiration;
            ProficiencyBonus = character.ProficiencyBonus;
            Initiative = character.Initiative;
            Speed = character.Speed;
            HitPoints = character.HitPoints;
            TemporaryHitPoints = character.TemporaryHitPoints;
            Name = character.CharacterName;
            Level = character.Level;
            CurrentExp = character.CurrentExp;
            HitPointDice = character.HitPointDice;
            Class = character.CharacterClass;
            Race = character.CharacterRace.RaceType;
            SubRace = character.CharacterRace.SubRace.RaceType;
            Weapons = character.Weapons;
            Armors = character.Armors;
        }

        internal IRace GetRace()
        {
            var race = Helper.GetRaceByType(Race);
            if (null != race)
                setSubrace(race);
            return race;
        }

        private void setSubrace(IRace race)
        {
            race.SetSubRace(Helper.GetSubRaceByType(SubRace));
        }
    }
}
