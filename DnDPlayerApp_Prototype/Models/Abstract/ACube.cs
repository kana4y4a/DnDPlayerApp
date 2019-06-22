namespace DnDPlayerApp_Prototype.Models.Abstract
{
    using System;
    using DnDPlayerApp_Prototype.Interfaces;

    public abstract class ACube : ICube
    {
        public int Min => 1;

        public int Max => getMax();
        internal abstract int getMax();

        public int Trow()
        {
            return new Random().Next(Min, Max);
        }
    }
}
