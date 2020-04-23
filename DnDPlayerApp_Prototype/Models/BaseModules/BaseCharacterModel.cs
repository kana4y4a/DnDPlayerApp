namespace DnDPlayerApp_Prototype.Models
{
    using System.Collections.Generic;
    using DnDPlayerApp_Prototype.Helpers;
    using DnDPlayerApp_Prototype.Interfaces;
    using DnDPlayerApp_Prototype.Models.Abstract;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public class BaseCharacterModel : ACharacter
    {
        // ICharacter
        private IList<IArmor> _armors;
        private IList<IWeapon> _weapons;
        private int _perception;
        private IClass _class;
        private string _name;
        private IRace _race;
        private int _crrentExp;
        private bool[,] _deathTrows;
        private ICube _hitPointDice;
        private int _hitPoints;
        private int _inspiration;
        private int _level;
        private int _proficiencyBonus;
        private int _temporaryHitPoints;

        // IStats
        private int _charisma;
        private int _constitution;
        private int _dexterity;
        private int _intelligence;
        private int _strenght;
        private int _wisdom;

        // ISkills
        private IList<Skill> _selectedSkills;

        public BaseCharacterModel()
        {
            // ICharacter
            _armors = new List<IArmor>();
            _weapons = new List<IWeapon>();
            _perception = 0;
            _class = null;
            _race = null;
            _crrentExp = 0;
            _deathTrows = new bool[,] { { false, false, false }, { false, false, false } };
            _hitPointDice = null;
            _hitPoints = 0;
            _inspiration = 0;
            _level = 1;
            _name = "New Player";
            _proficiencyBonus = 0;
            _temporaryHitPoints = 0;

            // IStats
            _charisma = 0;
            _constitution = 0;
            _dexterity = 0;
            _intelligence = 0;
            _strenght = 0;
            _wisdom = 0;

            // ISkills
            _selectedSkills = new List<Skill>();
        }

        #region ICharacter
        #region Armor
        protected override IEnumerable<IArmor> getArmors()
        {
            return _armors;
        }

        public void AddArmor(IArmor armor)
        {
            _armors.Add(armor);
        }

        public void RemoveArmor(int index)
        {
            _armors.RemoveAt(index);
        }
        #endregion

        #region Weapon
        protected override IEnumerable<IWeapon> getWeapons()
        {
            return _weapons;
        }

        public void AddWeapon(IWeapon weapon)
        {
            _weapons.Add(weapon);
        }

        public void RemoveWeapon(int index)
        {
            _weapons.RemoveAt(index);
        }
        #endregion

        protected override int getPerception()
        {
            return _perception;
        }

        protected override IClass getCharacterClass()
        {
            return _class;
        }

        protected override string getCharacterName()
        {
            return _name;
        }

        protected override IRace getCharacterRace()
        {
            return _race;
        }

        public void SetRace(IRace race)
        {
            _race = race;
        }

        public void SetSubRace(IRace subRace)
        {
            _race.SetSubRace(subRace);
        }

        protected override int getCurrentExp()
        {
            return _crrentExp;
        }

        protected override bool[,] getDeathSaves()
        {
            return _deathTrows;
        }

        protected override ICube getHitPointDice()
        {
            return _hitPointDice;
        }

        protected override int getHitPoints()
        {
            return _hitPoints;
        }

        protected override int getInitiative()
        {
            return Helper.GetModificator(Dexterity);
        }

        protected override int getInspiration()
        {
            return _inspiration;
        }

        protected override int getLevel()
        {
            return _level;
        }

        protected override int getProficiencyBonus()
        {
            return _proficiencyBonus;
        }

        protected override int getSpeed()
        {
            return _race.Speed;
        }

        protected override int getTemporaryHitPoints()
        {
            return _temporaryHitPoints;
        }
        #endregion

        #region IStats
        protected override int getCharisma()
        {
            return _charisma + _race.GetAbilityScoreIncrease(Stat.Charisma);
        }

        public void SetCharisma(int vale)
        {
            _charisma = vale;
        }

        protected override int getConstitution()
        {
            return _constitution + _race.GetAbilityScoreIncrease(Stat.Constitution);
        }

        public void SetConstitution(int value)
        {
            _constitution = value;
        }

        protected override int getDexterity()
        {
            return _dexterity + _race.GetAbilityScoreIncrease(Stat.Dexterity);
        }

        public void SetDexterity(int value)
        {
            _dexterity = value;
        }

        protected override int getIntelligence()
        {
            return _intelligence + _race.GetAbilityScoreIncrease(Stat.Intelligence);
        }

        public void SetIntelligence(int value)
        {
            _intelligence = value;
        }

        protected override int getStrenght()
        {
            return _strenght + _race.GetAbilityScoreIncrease(Stat.Strenght);
        }

        public void SetStrenght(int value)
        {
            _strenght = value;
        }

        protected override int getWisdom()
        {
            return _wisdom + _race.GetAbilityScoreIncrease(Stat.Wisdom);
        }

        public void SetWisdom(int value)
        {
            _wisdom = value;
        }
        #endregion

        #region ISkills
        protected override int getAcrobatics()
        {
            return getSkillModification(Skill.Acrobatics);
        }

        protected override int getAnimalHandling()
        {
            return getSkillModification(Skill.AnimalHandling);
        }

        protected override int getArcana()
        {
            return getSkillModification(Skill.Arcana);
        }

        protected override int getAthletics()
        {
            return getSkillModification(Skill.Athletics);
        }

        protected override int getDeception()
        {
            return getSkillModification(Skill.Deception);
        }

        protected override int getHistory()
        {
            return getSkillModification(Skill.History);
        }

        protected override int getInsight()
        {
            return getSkillModification(Skill.Insight);
        }

        protected override int getIntimidation()
        {
            return getSkillModification(Skill.Intimidation);
        }

        protected override int getInvestigation()
        {
            return getSkillModification(Skill.Investigation);
        }

        protected override int getMedicine()
        {
            return getSkillModification(Skill.Medicine);
        }

        protected override int getNature()
        {
            return getSkillModification(Skill.Nature);
        }

        protected override int getPercrption()
        {
            return getSkillModification(Skill.Percrption);
        }

        protected override int getPerformance()
        {
            return getSkillModification(Skill.Performance);
        }

        protected override int getPersuasion()
        {
            return getSkillModification(Skill.Persuasion);
        }

        protected override int getReligion()
        {
            return getSkillModification(Skill.Religion);
        }

        protected override int getSleightOfHand()
        {
            return getSkillModification(Skill.SleightOfHand);
        }

        protected override int getStealth()
        {
            return getSkillModification(Skill.Stealth);
        }

        protected override int getSurvival()
        {
            return getSkillModification(Skill.Survival);
        }
        #endregion

        private int getSkillModification(Skill skill)
        {
            var bonus = _selectedSkills.Contains(skill) ? 2 : 0;
            switch (skill)
            {
                case Skill.Acrobatics:
                    return Helper.GetModificator(Dexterity) + bonus;
                case Skill.AnimalHandling:
                    return Helper.GetModificator(Wisdom) + bonus;
                case Skill.Arcana:
                    return Helper.GetModificator(Intelligence) + bonus;
                case Skill.Athletics:
                    return Helper.GetModificator(Strenght) + bonus;
                case Skill.Deception:
                    return Helper.GetModificator(Charisma) + bonus;
                case Skill.History:
                    return Helper.GetModificator(Intelligence) + bonus;
                case Skill.Insight:
                    return Helper.GetModificator(Wisdom) + bonus;
                case Skill.Intimidation:
                    return Helper.GetModificator(Charisma) + bonus;
                case Skill.Investigation:
                    return Helper.GetModificator(Intelligence) + bonus;
                case Skill.Medicine:
                    return Helper.GetModificator(Wisdom) + bonus;
                case Skill.Nature:
                    return Helper.GetModificator(Intelligence) + bonus;
                case Skill.Percrption:
                    return Helper.GetModificator(Wisdom) + bonus;
                case Skill.Performance:
                    return Helper.GetModificator(Charisma) + bonus;
                case Skill.Persuasion:
                    return Helper.GetModificator(Charisma) + bonus;
                case Skill.Religion:
                    return Helper.GetModificator(Intelligence) + bonus;
                case Skill.SleightOfHand:
                    return Helper.GetModificator(Dexterity) + bonus;
                case Skill.Stealth:
                    return Helper.GetModificator(Dexterity) + bonus;
                case Skill.Survival:
                    return Helper.GetModificator(Wisdom) + bonus;
            }
            return 0;
        }
    }
}