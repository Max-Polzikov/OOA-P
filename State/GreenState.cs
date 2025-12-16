using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class GreenState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            context.State = new YellowState();
        }

        public string GetColor()
        {
            return "Зеленый";
        }
    }
}
