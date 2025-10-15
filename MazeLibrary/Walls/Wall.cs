namespace MazeLibrary.Walls
{
    public class Wall : MapSite
    {
        public Wall() { }

        public override void Enter()
        {
            Console.WriteLine("Вы уперлись встену");
        }
    }
}
