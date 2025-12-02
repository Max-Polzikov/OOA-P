using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SimpleCommand<TReceiver> : ICommand
    {
        private readonly TReceiver _receiver;
        private readonly Action<TReceiver> _action;

        public SimpleCommand(TReceiver receiver, Action<TReceiver> action)
        {
            _receiver = receiver;
            _action = action;
        }

        public void Execute()
        {
            _action(_receiver);
        }
    }
}
