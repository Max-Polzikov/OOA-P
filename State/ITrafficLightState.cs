namespace State
{
    public interface ITrafficLightState
    {
        void Handle(TrafficLight context);
        string GetColor();
    }
}
