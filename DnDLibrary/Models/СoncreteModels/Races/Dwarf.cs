namespace DnDLibrary.Models.СoncreteModels.Races
{
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Models.Emuns;

    public class Dwarf : BaseRaseModule
    {
        private int _constitutionBonus;

        public Dwarf() : base()
        {
            _constitutionBonus = 2;
        }

        protected override int getRaceAbilityScoreIncrease(Stat stat)
        {
            return stat == Stat.Constitution ? _constitutionBonus : 0;
        }
    }
}
