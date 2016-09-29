using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CofeeMachine_Exam1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("N1 = ");
            double N1 = (double.Parse(Console.ReadLine())*0.05);
            Console.WriteLine("N2 = ");
            double N2 =( double.Parse(Console.ReadLine())*0.10);
            Console.WriteLine("N3 = ");
            double N3 = (double.Parse(Console.ReadLine())*0.20);
            Console.WriteLine("N4 = ");
            double N4 = (double.Parse(Console.ReadLine())*0.50);
            Console.WriteLine("N5 = ");
            double N5 = (double.Parse(Console.ReadLine())*1.00);
            double sum = N1 + N2 + N3 + N4 + N5;
            Console.WriteLine("Money imput = ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Price of the product = ");
            double P = double.Parse(Console.ReadLine());
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (Math.Abs(P - A) <= sum && A > P)
            {
                Console.WriteLine("yes {0:F2}",(sum - (A - P)));
            }
            else if (P > A)
            {
                Console.WriteLine("more {0:F2}",(P - A));
            }
            else if (Math.Abs(P - A) > sum && A > P)
            {
                Console.WriteLine("no {0:F2}", Math.Abs((A - P) -sum));
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }
    }
}
