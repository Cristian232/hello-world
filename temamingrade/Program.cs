using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temamingrade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ConvertMinH(1,0));

            ManhatanGrid c = new ManhatanGrid(60, 60);
            ManhatanGrid v = new ManhatanGrid(40, 40);

            Console.WriteLine(manhattanD(c, v));

            Console.ReadLine();

        }

        public static Double ConvertMinH(int h , int min)
        {
            int x;

            if (min >= 60)
            {
                h = h + (min / 60);
                min = min % 60;
            }

            if (h >= 6) {
              h = h % 6;
            }

            x = (h * 60) + min;

            double minToG = 180d / 720d ;

            double finalT = minToG * x;

            return finalT;
        }

        public static int diff(int a,int b)
        {
            return a - b;
            
        }

        public static int manhattanD(ManhatanGrid x1,ManhatanGrid x2)
        {
            int x = 0;

            if (x1.Heightpos > x2.Heightpos)
            {
                x = x + diff(x1.Heightpos, x2.Heightpos);
            }
            else
            {
                x = x + diff(x2.Heightpos, x1.Heightpos);
            }

            if (x1.Widthpos > x2.Widthpos)
            {
                x = x + diff(x1.Widthpos, x2.Widthpos);
            }
            else
            {
                x = x + diff(x2.Widthpos, x1.Widthpos);
            }

            return x;
        }
    }
}
