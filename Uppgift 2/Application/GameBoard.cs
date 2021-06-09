using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class GameBoard
    {
        private List<IGameBoardBombingObserver> observers;
        private List<GameBoardPosition> bombingLocations;

        public GameBoard()
        {
            observers = new List<IGameBoardBombingObserver>();
            bombingLocations = new List<GameBoardPosition>();
        }

        public void AddBombingObserver(IGameBoardBombingObserver newObserver)
        {
            observers.Add(newObserver);
        }

        public void RemoveBombingObserver(IGameBoardBombingObserver observer)
        {
            observers.Remove(observer);
        }

        public void BombGameBoardPosition(IPlayer player, GameBoardPosition position)
        {
            bombingLocations.Add(position);
            Console.WriteLine($"Player <{player.Name}> is bombing {position}");
            Console.WriteLine();
            observers.ForEach(observer => observer.PositionedBombed(position));
        }
    }
}
