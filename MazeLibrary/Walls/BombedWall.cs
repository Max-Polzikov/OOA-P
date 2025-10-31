using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MazeLibrary.Walls
{
    public class BombedWall : Wall
    {
        public BombedWall() { }

        public void Enter()
        {
            Console.WriteLine("Вы уперлись в стену с бомбой");
        }

        public virtual BombedWall Clone() 
        {
            return new BombedWall();
        }   
    }
}
