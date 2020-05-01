﻿namespace DnDLibrary.Fabrics.Models
{
    using DnDLibrary.Models.СoncreteModels;

    public class CharacterDataModel
    {
        public F_Stats F_Stats { get; set; }
        public F_Character F_Character { get; set; }
        public F_Class F_Class { get; set; }
        public F_Skils F_Skils { get; set; }
        public F_Inventory F_Inventory { get; set; }

        public CharacterDataModel()
        {
            F_Stats = new F_Stats();
            F_Character = new F_Character();
            F_Class = new F_Class();
            F_Skils = new F_Skils();
            F_Inventory = new F_Inventory();
        }

        public CharacterDataModel(CharacterModel character) : base()
        {
            Setup(character);
        }

        public void Setup(CharacterModel character)
        {
            F_Stats = new F_Stats(character);
            F_Character = new F_Character(character);
            F_Class = new F_Class(character);
            F_Skils = new F_Skils(character);
            F_Inventory = new F_Inventory(character);
        }
    }
}