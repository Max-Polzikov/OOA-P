using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class TrafficLight
    {
        public ITrafficLightState _state { get; set; }

        public TrafficLight()
        {
            _state = new RedState();
        }

        public void Change()
        {
            _state.Handle(this);
        }

        public void ShowColor()
        {
            Console.WriteLine("Цвет сфетофора: " + _state.GetColor());
        }
    }
}
