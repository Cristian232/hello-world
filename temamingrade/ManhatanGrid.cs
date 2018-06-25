using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temamingrade
{
    class ManhatanGrid
    {
        int heightpos;
        int widthpos;

        public ManhatanGrid(int h, int w)
        {
            Heightpos = h;
            Widthpos = w;
        }

        public int Heightpos { get => heightpos; set => heightpos = value; }
        public int Widthpos { get => widthpos; set => widthpos = value; }
    }
}
