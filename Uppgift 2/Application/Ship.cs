using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Ship
    {
        private int length;
        private int startRow;
        private int startColumn;
        private bool isVertical;

        public Ship(int startRow, int startColumn, bool isVertical)
        {
            length = 3;
            this.startRow = startRow;
            this.startColumn = startColumn;
            this.isVertical = isVertical;
        }

        public bool IsHit(GameBoardPosition position)
        {
            int lowColumn = startColumn;
            int highColumn = isVertical ? startColumn : startColumn + length - 1;
            int lowRow = startRow;
            int highRow = isVertical ? startRow + length - 1 : startRow;

            return position.Column >= lowColumn && position.Column <= highColumn
                && position.Row >= lowRow && position.Row <= highRow;
        }
    }
}
