﻿namespace DnDLibrary.Models.Cubes
{
    using DnDLibrary.Models.Abstract;

    public class Cube_1d6 : ACube
    {
        protected override int getMax() { return 6; }
    }
}