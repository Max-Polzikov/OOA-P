using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class YellowState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            context.State = new RedState();
        }

        public string GetColor()
        {
            return "Желтый";
        }
    }
}
