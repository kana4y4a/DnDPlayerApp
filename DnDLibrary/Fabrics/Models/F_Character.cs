namespace DnDLibrary.Fabrics.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using DnDLibrary.Helpers;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.СoncreteModels.Races;
    using DnDLibrary.Models.СoncreteModels.SubRaces;

    internal class F_Character
    {
        public int Perception { get; set; }
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

        public F_Character(ICharacter character)
        {
            Setup(character);
        }

        public void Setup(ICharacter character)
        {
            Perception = character.Perception;
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

        public IRace GetRace()
        {
            IRace race;
            switch (Race)
            {
                case RaceType.None:
                    return null;
                case RaceType.Dwarf:
                    race = new Dwarf();
                    break; 
                //case RaceType.Elf:
                //    race = new Elf();
                //    break;
                //case RaceType.Halfling:
                //    race = new Halfling();
                //    break;
                //case RaceType.Human:
                //    race = new Human();
                //    break;
                //case RaceType.Dragonborn:
                //    race = new Dragonborn();
                //    break;
                //case RaceType.Gnome:
                //    race = new Gnome();
                //    break;
                //case RaceType.HalfElf:
                //    race = new HalfElf();
                //    break;
                //case RaceType.HalfOrk:
                //    race = new HalfOrk();
                //    break;
                //case RaceType.Tiefling:
                //    race = new Tiefling();
                //    break;
                default:
                    return null;
            }
            setSubrace(race);
            return race;
        }

        private void setSubrace(IRace race)
        {
            switch (SubRace)
            {
                case RaceType.None:
                    break;
                //case RaceType.HillDwarf:
                //    race.SetSubRace(new HillDwarf());
                //    break;
                case RaceType.MountainDwarf:
                    race.SetSubRace(new MountainDwarf());
                    break;
                //case RaceType.HighElf:
                //    race.SetSubRace(new HighElf());
                //    break;
                //case RaceType.WoodElf:
                //    race.SetSubRace(new WoodElf());
                //    break;
                //case RaceType.DarkElf:
                //    race.SetSubRace(new DarkElf());
                //    break;
                //case RaceType.ForestGnome:
                //    race.SetSubRace(new ForestGnome());
                //    break;
                //case RaceType.RockGnome:
                //    race.SetSubRace(new RockGnome());
                //    break;
                default:
                    break;
            }
        }
    }
}
