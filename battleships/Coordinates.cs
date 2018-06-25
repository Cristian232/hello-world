using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships
{
    class Coordinates
    {
        private int row;

        private int column;

        public int Row { get => row; set => row = value; }

        public int Column { get => column; set => column = value; }

        public Coordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }

    }
}
