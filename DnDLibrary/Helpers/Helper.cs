namespace DnDLibrary.Helpers
{
    using System;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.СoncreteModels.Races;
    using DnDLibrary.Models.СoncreteModels.SubRaces;

    public static class Helper
    {
        public static int GetModificator(int value)
        {
            return (int)Math.Ceiling((value - 10.0) / 2);
        }

        public static int TrowCubes(ICube cube, byte times = 1, byte bonus = 0)
        {
            var result = 0;
            for (int i = 0; i < times; ++i)
                result += cube.Trow() + bonus;
            return result;
        }

        public static IRace GetRaceByType(RaceType raceType)
        {
            IRace race;
            switch (raceType)
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
            return race;
        }

        public static IRace GetSubRaceByType(RaceType raceType)
        {
            IRace race;
            switch (raceType)
            {
                case RaceType.None:
                    return null;
                //case RaceType.HillDwarf:
                //    race = new HillDwarf();
                //    break;
                case RaceType.MountainDwarf:
                    race = new MountainDwarf();
                    break;
                //case RaceType.HighElf:
                //    race = new HighElf();
                //    break;
                //case RaceType.WoodElf:
                //    race = new WoodElf();
                //    break;
                //case RaceType.DarkElf:
                //    race = new DarkElf();
                //    break;
                //case RaceType.ForestGnome:
                //    race = new ForestGnome();
                //    break;
                //case RaceType.RockGnome:
                //    race = new RockGnome();
                //    break;
                default:
                    return null;
            }
            return race;
        }
    }
}
