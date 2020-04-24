namespace DnDLibrary.Models.СoncreteModels.SubRaces
{
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Models.Emuns;

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
