using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    interface IPlayer : IGameBoardBombingObserver
    {
        string Name { get; }
        bool IsAlive { get; }

        GameBoardPosition PlayTurn();
    }
}
