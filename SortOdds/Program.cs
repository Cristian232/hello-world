using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 7, 4, 0, 8, 3, 5, 9 };
        }

        public int countodds(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    count++;
                }
            }

            return count;
        }

        public int[] onlyodds(int[] a)
        {
            int count = countodds(a);

            int[] b = new int[count];
            int c = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 1)
                    {
                        b[c]= a[i];
                        c++;
                    }
                }
            return b;
        }

        public int[] oddspos(int[] a)
        {
            int count = countodds(a);
            int[] b = new int[count];
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    b[c] = i;
                    c++;
                }
            }
            return b;
        }

        public int[] sortoddsarr(int[] a)
        {
            int temp ;
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = 1; j < a.Length; j++)
                {
                    if (a[i]<a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            return a;
        }

        public int[] mergeodds(int[] a,int[] b,int[]c)// a the original arr , b pos , c sorted odds
        {
            for (int i = 0; i < c.Length; i++)
            {
                a[b[i]] = c[i];
            }

            return a;
        }

        public int[] finalMerge(int[] a)
        {
            int[] x = onlyodds(a);
            int[] c = oddspos(a);
            int[] v = sortoddsarr(x);
            a = mergeodds(a, c, v);

            return a;
        }

    }
}
