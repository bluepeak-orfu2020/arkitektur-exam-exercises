using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class CheatingRandomAIPlayer : RandomAIPlayer
    {
        public CheatingRandomAIPlayer(Ship ship) : base(ship)
        {

        }

        public override void PositionedBombed(GameBoardPosition position)
        {
            Console.WriteLine("Cheater");
            Console.WriteLine($"Missed <{Name}>");
        }
    }
}
