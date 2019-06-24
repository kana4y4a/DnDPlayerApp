namespace DnDPlayerApp_Prototype.Models.СoncreteModels.SubRaces
{
    using DnDPlayerApp_Prototype.Models.BaseModules;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public class MountainDwarf : BaseRaseModule
    {
        private int _strenghtBonus;

        public MountainDwarf() : base()
        {
            _strenghtBonus = 2;
        }

        protected override int getRaceAbilityScoreIncrease(Stat stat)
        {
            return stat == Stat.Strenght ? 2 : 0;
        }
    }
}
