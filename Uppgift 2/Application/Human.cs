using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Human : IPlayer
    {
        public string Name { get; private set; }

        public bool IsAlive { get; private set; }

        private Ship ship;

        public Human(string name, Ship ship)
        {
            Name = name;
            IsAlive = true;
            this.ship = ship;
        }

        public GameBoardPosition PlayTurn()
        {
            if (!IsAlive)
            {
                return null;
            }
            else
            {
                Console.WriteLine("Place you bombing strike");
                Console.WriteLine("Column (0-9)");
                int column = int.Parse(Console.ReadLine());
                Console.WriteLine("Row (0-9)");
                int row= int.Parse(Console.ReadLine());

                return new GameBoardPosition(row, column);
            }
        }

        public void PositionedBombed(GameBoardPosition position)
        {
            if (IsAlive)
            {
                if (ship.IsHit(position))
                {
                    Console.WriteLine($"I was hit! <{Name}> is out of the match");
                    IsAlive = false;
                }
                else
                {
                    Console.WriteLine($"Missed <{Name}>");
                }
            }
        }
    }
}
