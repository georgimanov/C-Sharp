namespace ConsoleForum
{
    using ConsoleForum.Interfaces;

    public class ConsoleForumMain
    {
        public static void Main()
        {
            IForum forum = new AdvancedForum();
            forum.Run();
        }
    }
}
