namespace DnDLibrary.Helpers
{
    using System;
    using DnDLibrary.Interfaces;

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
    }
}
