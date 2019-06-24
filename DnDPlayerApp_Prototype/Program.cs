namespace DnDPlayerApp_Prototype
{
    using System;
    using DnDPlayerApp_Prototype.Models;
    using DnDPlayerApp_Prototype.Models.Cubes;
    using DnDPlayerApp_Prototype.Models.СoncreteModels.Races;
    using DnDPlayerApp_Prototype.Models.СoncreteModels.SubRaces;

    class Program
    {
        static void Main(string[] args)
        {
            var c = new CharacterModel();
            c.SetConstitution(new Cube_1d20().Trow());
            c.SetStrenght(new Cube_1d20().Trow());
            var dwarf = new Dwarf();
            var sub = new MountainDwarf();
            c.SetRace(dwarf);
            c.SetSubRace(sub);
            var d = c.Strenght;
            var d1 = c.Constitution;

            Console.ReadKey();
        }
    }
}
