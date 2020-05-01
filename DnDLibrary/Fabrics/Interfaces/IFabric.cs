namespace DnDLibrary.Fabrics.Interfaces
{
    using DnDLibrary.Fabrics.Models;

    internal interface IFabric
    {
        void SaveCharacterData(CharacterDataModel f_characterModel);
        void LoadCharacterData(CharacterDataModel f_characterModel);
    }
}
