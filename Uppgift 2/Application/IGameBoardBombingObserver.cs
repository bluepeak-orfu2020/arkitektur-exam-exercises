using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    interface IGameBoardBombingObserver
    {
        void PositionedBombed(GameBoardPosition position);
    }
}
