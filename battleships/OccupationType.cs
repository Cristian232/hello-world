using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships
{
    public enum OccupationType
    {
        [Description("o")]
        Empty,
        [Description("x")]
        Hit,
        [Description("M")]
        Miss,
        [Description("D")]
        Destroyer,
        [Description("B")]
        Battleship,
        [Description("S")]
        MineSweeper,

    }
}
