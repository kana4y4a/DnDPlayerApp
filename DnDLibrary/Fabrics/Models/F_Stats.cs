namespace DnDLibrary.Fabrics.Models
{
    using DnDLibrary.Interfaces;

    internal class F_Stats
    {
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public F_Stats()
        {
        }

        public F_Stats(IStats stats)
        {
            Setup(stats);
        }

        public void Setup(IStats stats)
        {
            Strenght = stats.Strenght;
            Dexterity = stats.Dexterity;
            Constitution = stats.Constitution;
            Intelligence = stats.Intelligence;
            Wisdom = stats.Wisdom;
            Charisma = stats.Charisma;
        }
    }
}
