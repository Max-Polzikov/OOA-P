using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class CareTaker
    {
        private readonly Stack<Memento> _history = new Stack<Memento>();

        public void Backup(Code originator)
        {
            _history.Push(originator.Save());
        }

        public void Undo(Code originator)
        {
            if (_history.Count == 0) return;

            var memento = _history.Pop();
            originator.Restore(memento);
        }
    }
}
