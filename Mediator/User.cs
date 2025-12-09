using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class User
    {
        protected IChatMediator _mediator;
        protected string _name;

        public User(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
