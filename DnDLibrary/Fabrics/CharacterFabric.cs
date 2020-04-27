namespace DnDLibrary.Fabrics
{
    using System;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.СoncreteModels;
    using DnDLibrary.Helpers;
    using DnDLibrary.Models.СoncreteModels.Races;
    using DnDLibrary.Models.СoncreteModels.SubRaces;

    public class CharacterFabric
    {
        private string _rootStoragePath;
        private const string CHARACTER_DATABASE = @"\CharDB\";

        private CharacterFabric()
        {
        }

        public static CharacterFabric Instance { get; } = new CharacterFabric();

        public void SetRootPath(string rootPath)
        {
            _rootStoragePath = rootPath;
            FileHelper.CheckDirectory(_rootStoragePath + CHARACTER_DATABASE);
        }

        public CharacterModel CreateNewCharacter()
        {
            var c = new CharacterModel();
            c.SetRace(new Dwarf());
            c.SetSubRace(new MountainDwarf());
            return c;
        }

        public CharacterModel LoadCharacter(string name)
        {
            return FileHelper.LoadCharacter(_rootStoragePath + CHARACTER_DATABASE + name);
        }

        public void SaveCharacter(CharacterModel character)
        {
            FileHelper.SaveCharacter(character, _rootStoragePath + CHARACTER_DATABASE + character.CharacterName);
        }

        private void loadCharacterInventory(CharacterModel character)
        {

        }

        private void loadCharacterStats(CharacterModel character)
        {

        }
    }
}