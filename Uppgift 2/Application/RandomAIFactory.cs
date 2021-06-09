using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class RandomAIFactory : IAIFactory
    {
        private Random rng = new Random(Guid.NewGuid().GetHashCode());
        public IPlayer CreateAI()
        {
            int startRow = rng.Next(0, 9);
            int startColumn = rng.Next(0, 9);
            bool isVertical = rng.Next(0, 1) == 0;
            Ship ship = new Ship(startRow, startColumn, isVertical);
            if (rng.Next(0,10) < 1)
            {
                return new CheatingRandomAIPlayer(ship);
            }
            else
            {
                return new RandomAIPlayer(ship);
            }
        }
    }
}
