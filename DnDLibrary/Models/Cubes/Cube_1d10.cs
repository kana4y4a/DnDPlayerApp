namespace DnDLibrary.Models.Cubes
{
    using DnDLibrary.Models.Abstract;

    public class Cube_1d10 : ACube
    {
        protected override byte getMax() { return 10; }
    }
}
