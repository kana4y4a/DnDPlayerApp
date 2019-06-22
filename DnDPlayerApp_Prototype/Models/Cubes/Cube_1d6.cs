namespace DnDPlayerApp_Prototype.Models.Cubes
{
    using DnDPlayerApp_Prototype.Models.Abstract;

    class Cube_1d6 : ACube
    {
        internal override int getMax() { return 6; }
    }
}
