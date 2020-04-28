namespace DnDLibrary.Fabrics
{
    using System;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.СoncreteModels;
    using DnDLibrary.Helpers;
    using DnDLibrary.Models.СoncreteModels.Races;
    using DnDLibrary.Models.СoncreteModels.SubRaces;
    using DnDLibrary.Fabrics.Models;

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

        public void SaveCharacter(CharacterModel character)
        {
            var f_characterModule = new F_CharacterModel();
            character.SetupFCharacter(f_characterModule);
            FileHelper.SaveCharacter(f_characterModule, _rootStoragePath + CHARACTER_DATABASE + character.CharacterName);
        }

        public CharacterModel LoadCharacter(string name)
        {
            var f_character = new F_CharacterModel();
            var character = new CharacterModel();

            f_character = FileHelper.LoadCharacter(_rootStoragePath + CHARACTER_DATABASE + name);
            setupCharacter(f_character, character);
            return character;
        }

        private void setupCharacter(F_CharacterModel f_character, CharacterModel character)
        {
            character.SetupCharacter(f_character);
        }

        private void loadCharacterInventory(CharacterModel character)
        {

        }

        private void loadCharacterStats(CharacterModel character)
        {

        }
    }
}
