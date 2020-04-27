namespace DnDLibrary.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.Json;
    using DnDLibrary.Models.СoncreteModels;
    using System.IO;
    using System.Diagnostics;

    public static class FileHelper
    {
        internal static void CheckDirectory(string dirPath)
        {
            if (false == Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        internal static void SaveCharacter(CharacterModel chararcter, string filePath)
        {
            var jsonString = string.Empty;
            var options = new JsonSerializerOptions { IgnoreNullValues = true };

            jsonString = JsonSerializer.Serialize(chararcter);

            try
            {
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        internal static CharacterModel LoadCharacter(string filePath)
        {
            var jsonString = string.Empty;
            var character = new CharacterModel();
            var options = new JsonSerializerOptions { IgnoreNullValues = false };

            jsonString = File.ReadAllText(filePath);
            try
            {
                character = JsonSerializer.Deserialize<CharacterModel>(jsonString, options);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return character;
        }
    }
}
