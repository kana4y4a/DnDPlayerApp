namespace DnDPlayerApp_Prototype.Helpers
{
    using System;
    using DnDPlayerApp_Prototype.Interfaces;

    public static class Helper
    {
        public static int GetModificator(int value)
        {
            return (int)Math.Ceiling((value - 10.0) / 2);
        }

        public static int TrowCube(ICube cube, byte times)
        {
            var result = 0;
            for (int i = 0; i < times; ++i)
                result += cube.Trow();
            return result;
        }
    }
}
