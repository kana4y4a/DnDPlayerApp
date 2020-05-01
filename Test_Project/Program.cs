using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnDLibrary.Dictionaries;
using DnDLibrary.Models.СoncreteModels.Armor;
using DnDLibrary.Models.СoncreteModels;
using DnDLibrary.Fabrics;
using System.IO;
using DnDLibrary.Fabrics.Models;
using DnDLibrary.Models.СoncreteModels.Races;
using DnDLibrary.Models.СoncreteModels.SubRaces;

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFabric.Instance.SetRootPath(AppDomain.CurrentDomain.BaseDirectory);

            var c = CharacterFabric.Instance.CreateNewCharacter();
            c.SetRace(new Dwarf());
            c.SetSubRace(new MountainDwarf());
            c.AddArmor(new PaddedArmor());

            CharacterFabric.Instance.SaveCharacter(c);
            var c1 = CharacterFabric.Instance.LoadCharacter("New Player");
            var c2 = CharacterFabric.Instance.LoadCharacter("New Player");
        }
    }
}
