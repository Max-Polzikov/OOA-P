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

        public HelpHandler(IHelpHandler successor, Topic topic)
        {
            _successor = successor;
            _topic = topic;
        }


        public virtual void HandleHelp()
        {
            if (_topic != Topic.NoHelp)
            {
                Console.WriteLine($"Help:{_topic}");
            }
            else if (_successor != null)
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
