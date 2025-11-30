using ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class Application : HelpHandler
    {
        public Application(Topic topic) : base(null, topic) { }

        public override void HandleHelp()
        {
            Console.WriteLine($"Application help: {_topic}");
        }
    }
}
