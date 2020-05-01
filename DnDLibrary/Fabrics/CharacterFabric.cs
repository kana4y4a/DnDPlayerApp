namespace DnDLibrary.Fabrics
{
    using DnDLibrary.Models.СoncreteModels;
    using DnDLibrary.Helpers;
    using DnDLibrary.Models.СoncreteModels.Races;
    using DnDLibrary.Models.СoncreteModels.SubRaces;
    using DnDLibrary.Fabrics.Models;
    using DnDLibrary.Models.СoncreteModels.Armor;

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
            return new CharacterModel();
        }

        public void SaveCharacter(CharacterModel character)
        {
            var f_characterModule = new CharacterDataModel();
            character.SaveCharacterData(f_characterModule);
            FileHelper.SaveCharacter(f_characterModule, _rootStoragePath + CHARACTER_DATABASE + character.CharacterName);
        }

        public CharacterModel LoadCharacter(string name)
        {
            var f_character = new CharacterDataModel();
            var character = new CharacterModel();

            f_character = FileHelper.LoadCharacter(_rootStoragePath + CHARACTER_DATABASE + name);
            character.LoadCharacterData(f_character);
            return character;
        }

        private void loadCharacterInventory(CharacterModel character)
        {

        }

        private void loadCharacterStats(CharacterModel character)
        {

        }
    }
}
