using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class AliveRandomAIPlayerState : IAIPlayerState
    {
        private RandomAIPlayer player;

        public AliveRandomAIPlayerState(RandomAIPlayer player)
        {
            this.player = player;
        }

        public bool IsAlive()
        {
            return true;
        }

        public GameBoardPosition PlayTurn()
        {
            GameBoardPosition position;
            do
            {
                int column = player.Rng.Next(0, 9);
                int row = player.Rng.Next(0, 9);
                position = new GameBoardPosition(row, column);
            } while (player. Ship.IsHit(position));

            return position;
        }

        public void PositionedBombed(GameBoardPosition position)
        {
            if (player.Ship.IsHit(position))
            {
                Console.WriteLine($"I was hit! <{player.Name}> is out of the match");
                player.State = new DeadAIPlayerState();
            }
            else
            {
                Console.WriteLine($"Missed <{player.Name}>");
            }
        }
    }
}
