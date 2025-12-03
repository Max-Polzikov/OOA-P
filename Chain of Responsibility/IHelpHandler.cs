using Topics;
namespace Chain_Of_Responsibility
{
    public interface IHelpHandler
    {
        bool HasHelp();
        void SetHandler(IHelpHandler successor, Topic topic);
        void HandleHelp();
    }
}
