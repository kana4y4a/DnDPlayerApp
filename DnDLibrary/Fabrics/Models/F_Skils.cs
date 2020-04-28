namespace DnDLibrary.Fabrics.Models
{
    using System;
    using System.Collections.Generic;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;

    internal class F_Skils
    {
        int Acrobatics { get; set; }
        int AnimalHandling { get; set; }
        int Arcana { get; set; }
        int Athletics { get; set; }
        int Deception { get; set; }
        int History { get; set; }
        int Insight { get; set; }
        int Intimidation { get; set; }
        int Investigation { get; set; }
        int Medicine { get; set; }
        int Nature { get; set; }
        int Percrption { get; set; }
        int Performance { get; set; }
        int Persuasion { get; set; }
        int Religion { get; set; }
        int SleightOfHand { get; set; }
        int Stealth { get; set; }
        int Survival { get; set; }
        IList<Skill> SelectedSkills { get; set; }

        public F_Skils()
        {
        }

        public F_Skils(ISkills skills)
        {
            Setup(skills);
        }

        internal void Setup(ISkills skills)
        {
            Acrobatics = skills.Acrobatics;
            AnimalHandling = skills.AnimalHandling;
            Arcana = skills.Arcana;
            Athletics = skills.Athletics;
            Deception = skills.Deception;
            History = skills.History;
            Insight = skills.Insight;
            Intimidation = skills.Intimidation;
            Investigation = skills.Investigation;
            Medicine = skills.Medicine;
            Nature = skills.Nature;
            Percrption = skills.Percrption;
            Performance = skills.Performance;
            Persuasion = skills.Persuasion;
            Religion = skills.Religion;
            SleightOfHand = skills.SleightOfHand;
            Stealth = skills.Stealth;
            Survival = skills.Survival;
        }

        internal void AddSelectedSkills(IList<Skill> selectedSkills)
        {
            SelectedSkills = new List<Skill>(selectedSkills);
        }
    }
}
