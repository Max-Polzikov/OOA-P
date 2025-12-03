using Topics;
namespace ChainOfResponsibilit7y
{
    public interface IHelpHandler
    {
        bool HasHelp();
        void SetHandler(IHelpHandler successor, Topic topic);
        void HandleHelp();
    }
}
