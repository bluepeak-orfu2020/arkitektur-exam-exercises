using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class GameBoardPosition
    {
        public int Row { get; private set; }
        public int Column { get; private set; }

        public GameBoardPosition(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            if (Row < 0 || Row > 9)
            {
                throw new Exception($"Invalid Row {Row}");
            }
            if (Column < 0 || Column > 9)
            {
                throw new Exception($"Invalid Column {Column}");
            }
            return $"[col: {Column}, row: {Row}]";
        }
    }
}
