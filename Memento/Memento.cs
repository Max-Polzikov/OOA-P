namespace Memento
{
    public class Memento
    {
        public string _state { get; }

        public Memento(string state)
        {
            _state = state;
        }
    }
}
