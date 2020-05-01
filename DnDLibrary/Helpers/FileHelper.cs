namespace DnDLibrary.Helpers
{
    using System;
    using System.Text.Json;
    using System.IO;
    using System.Diagnostics;
    using System.Text.Json.Serialization;

    using DnDLibrary.Fabrics.Models;
    using DnDLibrary.Models.СoncreteModels.Races;
    using DnDLibrary.Interfaces;

    public static class FileHelper
    {
        internal static void CheckDirectory(string dirPath)
        {
            if (false == Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        internal static void SaveCharacter(CharacterDataModel chararcter, string filePath)
        {
            var jsonString = string.Empty;
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

            jsonString = JsonSerializer.Serialize(chararcter, options);

            try
            {
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        internal static CharacterDataModel LoadCharacter(string filePath)
        {
            var jsonString = string.Empty;
            var character = new CharacterDataModel();
            var options = new JsonSerializerOptions { IgnoreNullValues = false };
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

            jsonString = File.ReadAllText(filePath);
            try
            {
                character = JsonSerializer.Deserialize<CharacterDataModel>(jsonString, options);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return character;
        }
    }
}
