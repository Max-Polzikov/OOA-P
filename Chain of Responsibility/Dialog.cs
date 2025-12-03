using Chain_Of_Responsibility;
using System;
using Topics;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class Dialog : Widget
    {
        public Dialog(IHelpHandler successor, Topic topic = Topic.NO_HELP_TOPIC) : base(null, topic)
        {
            SetHandler(successor, topic);
        }

        public override void HandleHelp()
        {
            if (HasHelp())
            {
                Console.WriteLine($"Dialog help: {_topic}");
            }
            else
            {
                base.HandleHelp();
            }
        }
    }
}
