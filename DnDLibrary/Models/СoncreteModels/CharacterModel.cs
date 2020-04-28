namespace DnDLibrary.Models.СoncreteModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DnDLibrary.Fabrics.Models;
    using DnDLibrary.Helpers;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Abstract;
    using DnDLibrary.Models.Emuns;

    public class CharacterModel : ACharacter
    {
        // ICharacter
        private int _perception;
        private IClass _class;
        private string _name;
        private IRace _race;
        private int _curentExp;
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
        protected IList<Skill> _selectedSkills;

        // IInventory
        private byte _usedSlots;
        private byte _maxSlots;
        private byte _usedBagSlots;
        private byte _maxBagSlots;
        private IList<IItem> _items;

        public CharacterModel()
        {
            // ICharacter
            _perception = 0;
            _class = null;
            _race = null;
            _curentExp = 0;
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

            // IInventory
            _usedSlots = 0;
            _maxSlots = 24;
            _usedBagSlots = 1;
            _maxBagSlots = 5;
            _items = new List<IItem>();
        }

        #region ICharacter
        #region Armor
        protected override IEnumerable<IArmor> getArmors() => getItemByType<IArmor>(ItemType.Armor);

        public void AddArmor(IArmor armor)
        {
            _items.Add(armor);
        }

        public void RemoveArmor(UInt32 id)
        {
            removeItemById(id);
        }
        #endregion

        #region Weapon
        protected override IEnumerable<IWeapon> getWeapons() => getItemByType<IWeapon>(ItemType.Weapon);

        public void AddWeapon(IWeapon weapon)
        {
            _items.Add(weapon);
        }

        public void RemoveWeapon(UInt32 id)
        {
            removeItemById(id);
        }
        #endregion

        protected override int getPerception() => _perception;

        protected override IClass getCharacterClass() => _class;

        protected override string getCharacterName() => _name;

        protected override IRace getCharacterRace() => _race;

        public void SetRace(IRace race)
        {
            _race = race;
        }

        public void SetSubRace(IRace subRace)
        {
            _race.SetSubRace(subRace);
        }

        protected override int getCurrentExp() => _curentExp;

        protected override ICube getHitPointDice() => _hitPointDice;

        protected override int getHitPoints() => _hitPoints;

        protected override int getInitiative() => Helper.GetModificator(Dexterity);

        protected override int getInspiration() => _inspiration;

        protected override int getLevel() => _level;

        protected override int getProficiencyBonus() => _proficiencyBonus;

        protected override int getSpeed() => _race.Speed;

        protected override int getTemporaryHitPoints() => _temporaryHitPoints;
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

        #region IInventory
        protected override byte getUsedSlots() => _usedSlots;

        protected override byte getMaxSlots() => _maxSlots;

        protected override byte getUsedBagSlots() => _usedBagSlots;

        protected override byte getMaxBagSlots() => _maxBagSlots;

        protected override IEnumerable<IItem> getItems() => _items;
        #endregion

        #region Common

        public void AddSelectedSkill(Skill skill)
        {
            _selectedSkills.Add(skill);
        }

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

        private IEnumerable<I> getItemByType<I>(ItemType itemType)
        {
            return _items.Where(i => i.ItemType == itemType).Cast<I>();
        }

        private void removeItemById(UInt32 id)
        {
            var index = _items.IndexOf(_items.FirstOrDefault(i => i.Id == id));
            if (-1 != index)
                _items.RemoveAt(index);
        }

        internal void SetupCharacter(F_CharacterModel f_characterModel)
        {
            // ICharacter
            _perception = f_characterModel.F_Character.Perception;
            _class = f_characterModel.F_Character.Class;
            _race = f_characterModel.F_Character.GetRace();
            _curentExp = f_characterModel.F_Character.CurrentExp;
            _hitPointDice = f_characterModel.F_Character.HitPointDice;
            _hitPoints = f_characterModel.F_Character.HitPoints;
            _inspiration = f_characterModel.F_Character.Inspiration;
            _level = f_characterModel.F_Character.Level;
            _name = f_characterModel.F_Character.Name;
            _proficiencyBonus = f_characterModel.F_Character.ProficiencyBonus;
            _temporaryHitPoints = f_characterModel.F_Character.TemporaryHitPoints;

            // IStats
            _charisma = f_characterModel.F_Stats.Charisma;
            _constitution = f_characterModel.F_Stats.Constitution;
            _dexterity = f_characterModel.F_Stats.Dexterity;
            _intelligence = f_characterModel.F_Stats.Intelligence;
            _strenght = f_characterModel.F_Stats.Strenght;
            _wisdom = f_characterModel.F_Stats.Wisdom;

            // ISkills
            _selectedSkills = new List<Skill>();

            // IInventory
            _usedSlots = f_characterModel.F_Inventory.UsedSlots;
            _maxSlots = f_characterModel.F_Inventory.MaxSlots;
            _usedBagSlots = f_characterModel.F_Inventory.UsedBagSlots;
            _maxBagSlots = f_characterModel.F_Inventory.MaxBagSlots;
            _items = new List<IItem>(f_characterModel.F_Inventory.Items);
        }

        internal void SetupFCharacter(F_CharacterModel f_characterModel)
        {
            // ICharacter
            f_characterModel.F_Character.Perception = _perception;
            f_characterModel.F_Character.Class = _class;
            f_characterModel.F_Character.Race = _race.RaceType;
            f_characterModel.F_Character.SubRace = _race.SubRace.RaceType;
            f_characterModel.F_Character.CurrentExp = _curentExp;
            f_characterModel.F_Character.HitPointDice = _hitPointDice;
            f_characterModel.F_Character.HitPoints = _hitPoints;
            f_characterModel.F_Character.Inspiration = _inspiration;
            f_characterModel.F_Character.Level = _level;
            f_characterModel.F_Character.Name = _name;
            f_characterModel.F_Character.ProficiencyBonus = _proficiencyBonus;
            f_characterModel.F_Character.TemporaryHitPoints = _temporaryHitPoints;

            // IStats
            f_characterModel.F_Stats.Charisma = _charisma;
            f_characterModel.F_Stats.Constitution = _constitution;
            f_characterModel.F_Stats.Dexterity = _dexterity;
            f_characterModel.F_Stats.Intelligence = _intelligence;
            f_characterModel.F_Stats.Strenght = _strenght;
            f_characterModel.F_Stats.Wisdom = _wisdom;

            // ISkills
            f_characterModel.F_Skils.AddSelectedSkills(_selectedSkills);

            // IInventory
            f_characterModel.F_Inventory.UsedSlots = _usedSlots;
            f_characterModel.F_Inventory.MaxSlots = _maxSlots;
            f_characterModel.F_Inventory.UsedBagSlots = _usedBagSlots;
            f_characterModel.F_Inventory.MaxBagSlots = _maxBagSlots;
            f_characterModel.F_Inventory.Items = new List<IItem>(_items);
        }
        #endregion
    }
}