using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class RandomAIPlayer : IPlayer
    {
        public string Name { get; private set; }

        public bool IsAlive { get { return State.IsAlive(); } }

        public Ship Ship { get; private set; }

        public Random Rng { get; private set; }

        public IAIPlayerState State { get; set; }

        public RandomAIPlayer(Ship ship)
        {
            Rng = new Random(Guid.NewGuid().GetHashCode());
            Name = $"AI {Rng.Next()}";
            Ship = ship;
            State = new AliveRandomAIPlayerState(this);
        }

        public GameBoardPosition PlayTurn()
        {
            return State.PlayTurn();
        }

        public virtual void PositionedBombed(GameBoardPosition position)
        {
            State.PositionedBombed(position);
        }
    }
}
