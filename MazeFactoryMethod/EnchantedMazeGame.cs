using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;

namespace MazeFactoryMethod
{
    internal class EnchantedMazeGame : MazeGame
    {
        public EnchantedMazeGame() { }

        protected override Maze MakeMaze()
        {
            return new Maze();
        }
        protected override Room MakeRoom(int number)
        {
            return new EnchantedRoom(number);
        }

        protected override Door MakeDoor(Room roomFrom, Room roomTo)
        {
            return new EnchantedDoor(roomFrom,roomTo);
        }

        protected Spell Castspell() 
        {
            return new Spell("Шары мары");
        }
    }
}
