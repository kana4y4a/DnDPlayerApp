namespace DnDLibrary.Fabrics.Models
{
    using System;
    using DnDLibrary.Interfaces;

    public class F_Class
    {
        public F_Class()
        {
        }

        internal F_Class(IClass charClass)
        {
            Setup(charClass);
        }

        internal void Setup(IClass charClass)
        {
        }
    }
}
