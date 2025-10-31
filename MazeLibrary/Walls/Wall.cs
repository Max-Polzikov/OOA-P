namespace MazeLibrary.Walls
{
    public class Wall : IMapSite
    {
        public Wall() { }


        public  void Enter()
        {
            Console.WriteLine("Вы уперлись встену");
        }

        public virtual IMapSite Clone()
        {
            return new Wall();
        }
    }
}
