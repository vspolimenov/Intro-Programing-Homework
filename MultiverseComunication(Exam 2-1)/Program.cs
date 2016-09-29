using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseComunication_Exam_2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number;
            string stringNumbers = null;
            while (input != "")
            {
                string current = input.Substring(0, 3);
                //Console.WriteLine(current);
                Dictionary().TryGetValue(current, out number);
                try
                {
                    if (number == 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine("There is no a sign like \"{0}\"", current);
                    return;
                }
                if (number == 10)
                {
                    stringNumbers += "A";
                }
                else if (number == 11)
                {
                    stringNumbers += "B";
                }
                else if (number == 12)
                {
                    stringNumbers += "C";
                }
                else
                {
                    stringNumbers += number;
                }
                       
                input = input.Remove(0, 3);

            }
            Console.WriteLine(ToDecimal(stringNumbers));
            
            

        }
        static Dictionary<string,int> Dictionary()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("CHU", 0);
            dic.Add("TEL", 1);
            dic.Add("OFT", 2);
            dic.Add("IVA", 3);
            dic.Add("EMI", 4);
            dic.Add("VNP", 5);
            dic.Add("POD", 6);
            dic.Add("ERI", 7);
            dic.Add("CAD", 8);
            dic.Add("K-A", 9);
            dic.Add("IIA", 10);
            dic.Add("YLO", 11);
            dic.Add("PLA", 12);
            return dic;
        }
       static int ToDecimal(string stringNumbers)
        {
            int number = 0;
            int digit = 0;
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                if (stringNumbers[i] >= '0' && stringNumbers[i] <= '9')
                {
                    digit = stringNumbers[i] - '0';
                }
                else
                {
                    digit = stringNumbers[i] - 'A' + 10;
                }
                number += digit * (int)Math.Pow(13, ( stringNumbers.Length - i - 1));
            }

            return number;
        }
    }
}
