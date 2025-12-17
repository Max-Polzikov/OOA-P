using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class RedState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            context._state = new GreenState();
        }

        public string GetColor()
        {
            return "Красный";
        }
    }
}
