using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input system");
            int firstSystem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter output system");
            int secondSystem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            Console.WriteLine(DecimaToBase(BaseToDecimal(number, firstSystem), secondSystem));
        }
       static long BaseToDecimal(string number, int system)
        {
            long changedNumber = 0;
            int digit = 0;
            int l = 0;
            if (system == 10)
            {
                return int.Parse(number);
            }
            if (number[0] == '-')
            {
                l++;
            }
         else   if (number[0] == '1' && system == 2)
            {
                l++;
            }
            for (int i = l; i < number.Length; i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }
                changedNumber += digit * (long)Math.Pow(system, (number.Length - 1));
            }
            if (number[0] == '-')
            {
                return -changedNumber;
            }
            else if (number[0] == '1' && system == 2)
            {
                return -changedNumber;
            }
            return changedNumber;
        }
        static string DecimaToBase(long number, int system)
        {
            string changedNumber = null;
            long digit = 0;
            int temp = 0;
            if (number == 0)
            {
                Console.WriteLine("0");
            }
            if (number < 0)
            {
                number = Math.Abs(number);
                temp = 1;
            }
            while (number > 0)
            {
                digit = number % system;
                if (digit >= 0 && digit <= 9)
                {
                    changedNumber = (char)(digit + '0') + changedNumber;
                }
                else
                {
                    changedNumber = (char)(digit - 10 + 'A') + changedNumber;
                }
                number /= system;
            }
            
             if (temp == 1)
            {
                changedNumber = '-' + changedNumber;
            }
         
            return changedNumber;
        }
    }
}