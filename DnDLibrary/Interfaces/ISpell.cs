namespace DnDLibrary.Interfaces
{
    using System.Collections.Generic;
    using DnDLibrary.Models.Emuns;

    public interface ISpell
    {
        string Name { get; }
        string Description { get; }
        byte Range { get; }
        byte Duration { get; }

        CastType CastType { get; }
        CastRangeType RangeType { get; }
        SpellDurationType DurationType { get; }

        IEnumerable<IItem> Components { get; }
        IAction Action { get; }
    }
}
