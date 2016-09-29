using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAHouse_Softuniada2_
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int n = int.Parse(Console.ReadLine());
            Stopwatch s = Stopwatch.StartNew();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    if (j == n - 1 + i || j == n - 1 - i)
                    {
                        Console.Write("*");
                    }
                    else if (j > n - 1 - i && j < n - 1 + i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    if ((j == 0 && i == 0) || (j == 2 * n - 2 && i == n - 1) || (j == 0 && i == n - 1) || (j == 2 * n - 2 && i == 0)
                || (j == 2 * n - 2 && i == 0) || (j == 0 && i == n - 1) || (j == 2 * n - 2 && i == n - 1) || (j == 2 * n - 2 && i == n - 1))
                    {
                        Console.Write("+");
                    }
                    else if (i == 0 || i == n - 1)
                    {
                        Console.Write("-");
                    }
                    else if (j == 0 || j == 2 * n - 2)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);
        }
    }
}
