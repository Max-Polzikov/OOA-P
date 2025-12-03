using Chain_Of_Responsibility;
using Topics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class Widget : HelpHandler
    {
        protected Widget _parent;

        protected Widget(Widget parent = null, Topic topic = Topic.NoHelp) : base(parent, topic)
        {
            _parent = parent;
        }
    }
}
