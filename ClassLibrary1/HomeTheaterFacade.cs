using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amp;
        private readonly DvdPlayer _dvd;
        private readonly Projector _projector;
        private readonly TheaterLights _lights;

        public HomeTheaterFacade(Amplifier amp, DvdPlayer dvd, Projector projector, TheaterLights lights)
        {
            _amp = amp;
            _dvd = dvd;
            _projector = projector;
            _lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");

            _lights.Dim(30);
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd();
            _amp.SetSurroundSound();
            _dvd.On();
            _dvd.Play(movie);
        }
    }
}
