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

        internal static void SaveCharacter(F_CharacterModel chararcter, string filePath)
        {
            var jsonString = string.Empty;
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            options.Converters.Add(new ConcreteConverter<IRace>());

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

        internal static F_CharacterModel LoadCharacter(string filePath)
        {
            var jsonString = string.Empty;
            var character = new F_CharacterModel();
            var options = new JsonSerializerOptions { IgnoreNullValues = false };
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            options.Converters.Add(new ConcreteConverter<IRace>());

            jsonString = File.ReadAllText(filePath);
            try
            {
                character = JsonSerializer.Deserialize<F_CharacterModel>(jsonString, options);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return character;
        }
    }

    internal class ConcreteConverter<T> : JsonConverter<T>
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return default(T);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if (value is IRace race)
            {
                writer.WriteStringValue(race.RaceType.ToString());
            }
        }
    }
}
