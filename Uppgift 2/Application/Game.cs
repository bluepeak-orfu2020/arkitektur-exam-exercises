using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Game
    {
        private List<IPlayer> players;
        private GameBoard gameBoard;

        public void Init(string[] args)
        {
            // Gets number of AI players
            int numAis = int.Parse(args[0]);
            // What type of AI to use
            string aiEngine = args[1];

            // Create game board
            gameBoard = new GameBoard();

            // Create empty list of players
            players = new List<IPlayer>();

            // Get the AI factory
            IAIFactory aiFactory = GetFactory(aiEngine);

            // Create AI players
            for (int i = 0; i < numAis; i++)
            {
                players.Add(aiFactory.CreateAI());
            }

            // Read the player's name and age from the console
            Console.WriteLine("Enter player name:");
            string name = Console.ReadLine();

            // Get ship row and column info from console
            Console.WriteLine("Place you ship (length: 3)");
            Console.WriteLine("Place ship vertical? (y/n)");
            bool shipOrientationVertical = Console.ReadLine() == "y";
            Console.WriteLine("Place ship start row (0-9)");
            int shipStartRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Place ship start column (0-9)");
            int shipStartColumn = int.Parse(Console.ReadLine());

            // Create ship for human player
            Ship humanShip = new Ship(shipStartRow, shipStartColumn, shipOrientationVertical);

            // Create and add player
            IPlayer human = new Human(name, humanShip);
            players.Add(human);

            // Register players with the game board
            foreach(IPlayer player in players)
            {
                gameBoard.AddBombingObserver(player);
            }

            // Shuffle players
        }

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("-- Game is starting! --");
            Console.WriteLine("Randomizing player order");
            players = players.OrderBy(p => Guid.NewGuid()).ToList();
            Console.WriteLine();
            Console.WriteLine();

            int roundCount = 1;
            // Main game loop. Keep running while there are more than 1 player left
            while (players.Where(player => player.IsAlive).Count() > 1)
            {
                // Each player takes its turn
                foreach (IPlayer player in players) {
                    // Ask player for position to bomb
                    GameBoardPosition bombing = player.PlayTurn();
                    Console.WriteLine();
                    // If player provided bomb location
                    if (bombing != null)
                    {
                        // Register bombing on game board
                        gameBoard.BombGameBoardPosition(player, bombing);
                        Console.WriteLine();
                        // If the bomb hit all players except one we want to fininsh the game
                        if (players.Where(player => player.IsAlive).Count() <= 1)
                        {
                            break;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine($"-- round #{roundCount++} over (players remaining: {players.Where(player => player.IsAlive).Count()}) --");
                Console.WriteLine();
                Console.WriteLine();
            }

            // Print leader board
            string winner = players.Where(player => player.IsAlive).Select(player => player.Name).FirstOrDefault();
            Console.WriteLine($"Game is over. Winner {winner}");
        }

        

        private IAIFactory GetFactory(string engineName)
        {
            if (engineName == "random")
            {
                return new RandomAIFactory();
            }
            else
            {
                throw new Exception($"Unknown AI engine {engineName}");
            }
        }
    }
}
