using AbstractFactory;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MazeGameFactory game = new MazeGameFactory();

                UsualMazeFactory usualfactory = new UsualMazeFactory();
                game.CreateMaze(usualfactory);

                EnchantedMazeFactory enchantedfactory = new EnchantedMazeFactory();
                game.CreateMaze(enchantedfactory);

                var room = new EnchantedRoom(3);
                room.Enter();
                room.CastSpell();

                BombedMazeFactory bombedfactory = new BombedMazeFactory();
                game.CreateMaze(bombedfactory);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}