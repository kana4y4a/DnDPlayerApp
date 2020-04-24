namespace DnDLibrary.Dictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LanguageHelper
    {
        private static readonly Dictionary<UInt32, string> _dictionary;

        public static string GetString(UInt32 key)
        {
            return key == 0 ? "" : _dictionary[key];
        }
    }
}
