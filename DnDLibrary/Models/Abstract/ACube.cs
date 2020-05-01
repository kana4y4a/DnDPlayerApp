namespace DnDLibrary.Models.Abstract
{
    using System;
    using DnDLibrary.Interfaces;

    public abstract class ACube : ICube
    {
        public byte Min => 1;

        public byte Max => getMax();
        protected abstract byte getMax();

        public byte Trow()
        {
            return Min != Max ? (byte)(new Random().Next(Min, Max)) : Max;
        }

        public override string ToString()
        {
            return Min + "d" + getMax();
        }
    }
}
