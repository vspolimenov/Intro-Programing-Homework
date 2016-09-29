using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrouOfEqualSum_Softuniada_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[4];
              for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("numbers[{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());

            }
            Stopwatch s = Stopwatch.StartNew();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            if (numbers[3] == numbers[0] + numbers[1] + numbers[2])
            {
                Console.WriteLine("Yes");
                Console.WriteLine(numbers[3]);
            }
            else if(numbers[0] + numbers[3] == numbers[1] + numbers[2])
            {
                Console.WriteLine("Yes");
                Console.WriteLine(numbers[3] + numbers[0]);
            }
            else
            {
                Console.WriteLine("No");
            }
            s.Stop();
            Console.WriteLine("Elapsed Time: {0} ms", s.ElapsedMilliseconds);
        }
    }
}
