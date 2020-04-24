namespace DnDLibrary.Models.Abstract
{
    using System;
    using DnDLibrary.Interfaces;

    public abstract class ACube : ICube
    {
        public int Min => 1;

        public int Max => getMax();
        protected abstract int getMax();

        public int Trow()
        {
            return new Random().Next(Min, Max);
        }

        public override string ToString()
        {
            return Min + "d" + getMax();
        }
    }
}
