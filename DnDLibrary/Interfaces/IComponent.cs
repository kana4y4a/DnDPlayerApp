namespace DnDLibrary.Interfaces
{
    public interface IComponent
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        byte Amount { get; }
    }
}
