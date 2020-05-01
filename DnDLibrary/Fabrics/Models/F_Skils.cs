namespace DnDLibrary.Fabrics.Models
{
    using System;
    using System.Collections.Generic;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;

    public class F_Skils
    {
        public int Acrobatics { get; set; }
        public int AnimalHandling { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Deception { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidation { get; set; }
        public int Investigation { get; set; }
        public int Medicine { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Performance { get; set; }
        public int Persuasion { get; set; }
        public int Religion { get; set; }
        public int SleightOfHand { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }
        public IList<Skill> SelectedSkills { get; set; }

        public F_Skils()
        {
            SelectedSkills = new List<Skill>();
        }

        internal F_Skils(ISkills skills) : base()
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
            Perception = skills.Perception;
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
