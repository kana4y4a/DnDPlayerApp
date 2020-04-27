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

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFabric.Instance.SetRootPath(AppDomain.CurrentDomain.BaseDirectory);
            var c = CharacterFabric.Instance.CreateNewCharacter();
            CharacterFabric.Instance.SaveCharacter(c);
            var c1 = CharacterFabric.Instance.LoadCharacter("New Player");
        }
    }
}
