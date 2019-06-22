namespace DnDPlayerApp_Prototype
{
    using System;
    using DnDPlayerApp_Prototype.Models.Cubes;

    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Helpers.Helper.TrowCube(new Cube_1d20(), 1);
            var result2 = Helpers.Helper.TrowCube(new Cube_1d20(), 2);
            var result3 = Helpers.Helper.TrowCube(new Cube_1d4(), 5);

            var test = new Cube_1d10().Trow();

            Console.ReadKey();
        }
    }
}
