using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] a = { "afdsg" , "fgdgfjdj" ,"fadhdfhad","adjagjgjdaj","adfjadfjaja","adfhah","adfhahhah"};

            

        }

        class B
        {
            public int[] StringarrTointarr(String[] a)
            {
                int[] b = new int[a.Length];
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = a[i].Length;
                }

                return b;
            }



            public int[] intarrwithk(int[] b, int k)
            {
                int[] c = new int[b.Length - k + 1];
                for (int i = 0; i < c.Length; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        c[i] += b[j + i];
                    }

                }

                return c;
            }

            public int gethighpos(int[] a)
            {
                int temp = a[a.Length - 1];
                int b = 0;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > temp)
                    {
                        temp = a[i];
                    }
                }

                for (int i = 0; i < a.Length; i++)
                {
                    if (temp.Equals(a[i]))
                    {
                        b = i;
                    }
                }

                return b;
            }

            public string showString(int highpos, string[] a, int k)
            {
                string x = "";
                for (int i = 0; i < k; i++)
                {
                    x += a[highpos + i];
                }

                return x;
            }

            public void showfinal(String[] a,int k)
            {
                int[] z = StringarrTointarr(a);
                int[] x = intarrwithk(z, k);
                int c = gethighpos(x);
                String v = showString(c, a, k);
                Console.WriteLine(v);
            }

            public void show(string[] a, int k)
            {
                int[] x = StringarrTointarr(a);
                int[] y = intarrwithk(x, k);

                foreach (int c in y)
                {
                    Console.WriteLine(c);
                }

            }

        }
    }

}
