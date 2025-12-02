using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands = new();

        public void Add(ICommand command) => _commands.Add(command);

        public void Remove(ICommand command) => _commands.Remove(command);

        public void Execute()
        {
            foreach (var command in _commands)
                command.Execute();
        }
    }
}
