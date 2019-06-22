namespace DnDPlayerApp_Prototype.Models.Cubes
{
    using DnDPlayerApp_Prototype.Models.Abstract;

    class Cube_1d100 : ACube
    {
        internal override int getMax() { return 100; }
    }
}
