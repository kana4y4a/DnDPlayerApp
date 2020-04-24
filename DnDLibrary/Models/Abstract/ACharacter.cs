namespace DnDLibrary.Models.Abstract
{
    using System.Collections.Generic;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;

    public abstract class ACharacter : ICharacter, IStats, IClass, ISkills
    {
        #region ICharacter
        public int Perception => getPerception();
        protected abstract int getPerception();

        public int Inspiration => getInspiration();
        protected abstract int getInspiration();

        public int ProficiencyBonus => getProficiencyBonus();
        protected abstract int getProficiencyBonus();

        public int Initiative => getInitiative();
        protected abstract int getInitiative();

        public int Speed => getSpeed();
        protected abstract int getSpeed();

        public int HitPoints => getHitPoints();
        protected abstract int getHitPoints();

        public int TemporaryHitPoints => getTemporaryHitPoints();
        protected abstract int getTemporaryHitPoints();

        public ICube HitPointDice => getHitPointDice();
        protected abstract ICube getHitPointDice();

        public bool[,] DeathSaves => getDeathSaves();
        protected abstract bool[,] getDeathSaves();

        public IEnumerable<IWeapon> Weapons => getWeapons();
        protected abstract IEnumerable<IWeapon> getWeapons();

        public IEnumerable<IArmor> Armors => getArmors();
        protected abstract IEnumerable<IArmor> getArmors();

        public IClass CharacterClass => getCharacterClass();
        protected abstract IClass getCharacterClass();

        public IRace CharacterRace => getCharacterRace();
        protected abstract IRace getCharacterRace();

        public string CharacterName => getCharacterName();
        protected abstract string getCharacterName();

        public int Level => getLevel();
        protected abstract int getLevel();

        public int CurrentExp => getCurrentExp();
        protected abstract int getCurrentExp();
        #endregion

        #region IStats
        public int Strenght => getStrenght();
        protected abstract int getStrenght();

        public int Dexterity => getDexterity();
        protected abstract int getDexterity();

        public int Constitution => getConstitution();
        protected abstract int getConstitution();

        public int Intelligence => getIntelligence();
        protected abstract int getIntelligence();

        public int Wisdom => getWisdom();
        protected abstract int getWisdom();

        public int Charisma => getCharisma();
        protected abstract int getCharisma();
        #endregion

        #region ISkills
        public int Acrobatics => getAcrobatics();
        protected abstract int getAcrobatics();

        public int AnimalHandling => getAnimalHandling();
        protected abstract int getAnimalHandling();

        public int Arcana => getArcana();
        protected abstract int getArcana();

        public int Athletics => getAthletics();
        protected abstract int getAthletics();

        public int Deception => getDeception();
        protected abstract int getDeception();

        public int History => getHistory();
        protected abstract int getHistory();

        public int Insight => getInsight();
        protected abstract int getInsight();

        public int Intimidation => getIntimidation();
        protected abstract int getIntimidation();

        public int Investigation => getInvestigation();
        protected abstract int getInvestigation();

        public int Medicine => getMedicine();
        protected abstract int getMedicine();

        public int Nature => getNature();
        protected abstract int getNature();

        public int Percrption => getPercrption();
        protected abstract int getPercrption();

        public int Performance => getPerformance();
        protected abstract int getPerformance();

        public int Persuasion => getPersuasion();
        protected abstract int getPersuasion();

        public int Religion => getReligion();
        protected abstract int getReligion();

        public int SleightOfHand => getSleightOfHand();
        protected abstract int getSleightOfHand();

        public int Stealth => getStealth();
        protected abstract int getStealth();

        public int Survival => getSurvival();
        protected abstract int getSurvival();
        #endregion
    }
}
