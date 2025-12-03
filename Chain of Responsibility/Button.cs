using Chain_Of_Responsibility;
using System;
using Topics;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class Button : HelpHandler
    {
        public Button(Widget parent, Topic topic = Topic.NoHelp)
        : base(parent, topic) { }

        public override void HandleHelp()
        {
            if (_topic != Topic.NoHelp)
            {
                Console.WriteLine($"Button Help:{_topic}");
            }
            else
            {
                base.HandleHelp();
            }
        }
    }
}
