using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.Init(args);
            game.Start();
        }
    }
}
