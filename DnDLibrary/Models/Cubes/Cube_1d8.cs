namespace DnDLibrary.Models.Cubes
{
    using DnDLibrary.Models.Abstract;

    public class Cube_1d8 : ACube
    {
        protected override byte getMax() { return 8; }
    }
}
