namespace DnDPlayerApp_Prototype.Models.СoncreteModels.Races
{
    using DnDPlayerApp_Prototype.Models.BaseModules;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public class Dwarf : BaseRaseModule
    {
        private int _constitutionBonus;

        public Dwarf() : base()
        {
            _constitutionBonus = 2;
        }

        protected override int getRaceAbilityScoreIncrease(Stat stat)
        {
            return stat == Stat.Constitution ? 2 : 0;
        }
    }
}
