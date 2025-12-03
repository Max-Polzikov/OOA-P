using Chain_Of_Responsibility;
using System;
using Topics;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class Dialog : Widget
    {
        public Dialog(IHelpHandler successor, Topic topic = Topic.NoHelp) : base(null, topic) { }

        public override void HandleHelp()
        {
            if (_topic != Topic.NoHelp)
            {
                Console.WriteLine($"Dialog Help:{_topic}");
            }
            else
            {
                base.HandleHelp();
            }
        }
    }
}
