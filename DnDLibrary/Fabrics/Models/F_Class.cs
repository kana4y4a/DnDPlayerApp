namespace DnDLibrary.Fabrics.Models
{
    using System;
    using DnDLibrary.Interfaces;

    internal class F_Class
    {
        public F_Class()
        {
        }

        public F_Class(IClass charClass)
        {
            Setup(charClass);
        }

        public void Setup(IClass charClass)
        {
        }
    }
}
