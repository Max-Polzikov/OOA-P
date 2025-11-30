namespace ChainOfResponsibility
{
    public enum Topic
    {
        NO_HELP_TOPIC = -1,
        PRINT_TOPIC = 1,
        PAPER_ORIENTATION_TOPIC = 2,
        APPLICATION_TOPIC = 3
    }
    public interface IHelpHandler
    {
        bool HasHelp();
        void SetHandler(IHelpHandler successor, Topic topic);
        void HandleHelp();
    }
}
