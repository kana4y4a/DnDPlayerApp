namespace DnDPlayerApp_Prototype.Interfaces
{
    using System.Collections.Generic;
    using DnDPlayerApp_Prototype.Models.Emuns;

    public interface ISpell
    {
        string Name { get; }
        string Description { get; }
        byte Range { get; }
        byte Duration { get; }

        CastType CastType { get; }
        RangeType RangeType { get; }
        SpellDurationType DurationType { get; }

        IEnumerable<IComponent> Components { get; }
        IAction Action { get; }
    }
}
