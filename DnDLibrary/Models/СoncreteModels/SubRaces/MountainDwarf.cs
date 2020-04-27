namespace DnDLibrary.Models.СoncreteModels.SubRaces
{
    using DnDLibrary.Models.BaseModules;
    using DnDLibrary.Models.Emuns;

    public class MountainDwarf : BaseRaceModule
    {
        private int _strenghtBonus;

        public MountainDwarf() : base()
        {
            _strenghtBonus = 2;
        }

        protected override int getRaceAbilityScoreIncrease(Stat stat)
        {
            return stat == Stat.Strenght ? _strenghtBonus : 0;
        }
    }
}
