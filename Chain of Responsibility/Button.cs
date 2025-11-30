using ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class Button : HelpHandler
    {
        public Button(Widget parent, Topic topic = Topic.NO_HELP_TOPIC)
        : base(parent, topic) { }

        public override void HandleHelp()
        {
            if (HasHelp())
            {
                Console.WriteLine($"Button help: {_topic}");
            }
            else
            {
                base.HandleHelp();
            }
        }
    }
}
