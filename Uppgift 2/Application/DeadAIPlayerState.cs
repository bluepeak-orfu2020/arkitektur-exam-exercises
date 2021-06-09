using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class DeadAIPlayerState : IAIPlayerState
    {
        public bool IsAlive()
        {
            return false;
        }

        public GameBoardPosition PlayTurn()
        {
            return null;
        }

        public void PositionedBombed(GameBoardPosition position)
        {
            // Intentional empty
        }
    }
}
