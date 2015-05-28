namespace ConsoleForum.Interfaces
{
    public interface ICommand : IExecutable
    {
        IForum Forum { get; }
    }
}
