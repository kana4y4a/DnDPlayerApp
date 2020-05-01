namespace DnDLibrary.SystemDictionaries
{
    using System.Collections.Generic;

    public static class LanguageHelper
    {
        private static readonly IDictionary<uint, string> _dictionary = new Dictionary<uint, string>()
        {
            { 1u, "" },
        };

        public static string GetString(uint key) => key == 0 ? "" : _dictionary[key];
    }
}
