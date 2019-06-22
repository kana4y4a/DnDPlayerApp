namespace DnDPlayerApp_Prototype.Interfaces
{
    using System.Collections.Generic;

    public interface ISpell
    {
        string Name { get; }
        string Description { get; }
        IAction Action { get; }
        int Range { get; }
        IList<IComponent> Components { get; }
        int Duration { get; }
    }
}
