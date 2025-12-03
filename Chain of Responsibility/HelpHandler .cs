using Chain_Of_Responsibility;
using Topics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class HelpHandler : IHelpHandler
    {
        protected IHelpHandler _successor;
        protected Topic _topic;

        public HelpHandler(IHelpHandler successor = null, Topic topic = Topic.NO_HELP_TOPIC)
        {
            _successor = successor;
            _topic = topic;
        }

        public virtual bool HasHelp()
        {
            return _topic != Topic.NO_HELP_TOPIC;
        }

        public virtual void SetHandler(IHelpHandler successor, Topic topic)
        {
            _successor = successor;
            _topic = topic;
        }

        public virtual void HandleHelp()
        {
            if (_successor != null)
            {
                _successor.HandleHelp();
            }
            else
            {
                Console.WriteLine("No help available.");
            }
        }
    }
}
