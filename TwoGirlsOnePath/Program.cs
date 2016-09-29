using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoGirlsOnePath
{
    class Program
    {
        static List<int> pathCells = new List<int>();
        static void Main(string[] args)
        {
            ReadingUserInput();

            int mollysStartPossition = 0;
            int mollysStartScore = 0;
            int dollysStartPossition = pathCells.Count - 1;
            int dollysStartScore = 0;

            CollectingFlowers(mollysStartPossition,dollysStartPossition,mollysStartScore, dollysStartScore);
        }
        static void ReadingUserInput()
        {
            var userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == ' ')
                {
                    pathCells.Add(int.Parse(userInput.Substring(0, i)));
                    userInput = userInput.Remove(0, i);
                    i = 0;
                }
            }
            pathCells.Add(int.Parse(userInput));
        }
        static void CollectingFlowers(int mollysPossition, int dollysPossition, int mollysScore, int dollysScore)
        {
            while (true)
            {
                if (mollysPossition > pathCells.Count)
                {
                    mollysPossition -= pathCells.Count;
                }

                if (dollysPossition < 0)
                {
                    dollysPossition += pathCells.Count;
                }

                if (mollysPossition == dollysPossition && pathCells[mollysPossition] != 0 && pathCells[mollysPossition] % 2 == 0)
                {
                    int mollysCurretnCell = mollysPossition;
                    mollysScore += pathCells[mollysPossition] / 2;
                    dollysScore += pathCells[dollysPossition] / 2;
                    mollysPossition += pathCells[mollysPossition];
                    dollysPossition -= pathCells[dollysPossition];
                    pathCells[mollysCurretnCell] = 0;
                }

                else if (mollysPossition == dollysPossition && pathCells[mollysPossition] != 0 && pathCells[mollysPossition] % 2 == 1)
                {
                    int mollysCurretnCell = mollysPossition;
                    mollysScore += (pathCells[mollysPossition] - 1) / 2;
                    dollysScore += (pathCells[dollysPossition] - 1) / 2;
                    mollysPossition += pathCells[mollysPossition];
                    dollysPossition -= pathCells[dollysPossition];
                    pathCells[mollysCurretnCell] = 1;
                }

                else if (mollysPossition != dollysPossition && pathCells[mollysPossition] != 0 && pathCells[dollysPossition] != 0)
                {
                    int mollysCurretnCell = mollysPossition;
                    int dollysCurrentCell = dollysPossition;
                    mollysScore += pathCells[mollysPossition];
                    dollysScore += pathCells[dollysPossition];
                    mollysPossition += pathCells[mollysPossition];
                    dollysPossition -= pathCells[dollysPossition]; 
                    pathCells[mollysCurretnCell] = 0;
                    pathCells[dollysCurrentCell] = 0;
                }

                else if (mollysPossition != dollysPossition && pathCells[mollysPossition] == 0 && pathCells[dollysPossition] != 0)
                {
                    dollysScore += pathCells[dollysPossition];
                    Console.WriteLine("Dolly");
                    Console.WriteLine("{0} {1}", mollysScore, dollysScore);
                    break;
                }

                else if (mollysPossition != dollysPossition && pathCells[mollysPossition] != 0 && pathCells[dollysPossition] == 0)
                {
                    dollysScore += pathCells[mollysPossition];
                    Console.WriteLine("Molly");
                    Console.WriteLine("{0} {1}", mollysScore, dollysScore);
                    break;
                }

                else if (mollysPossition != dollysPossition && pathCells[mollysPossition] == 0 && pathCells[dollysPossition] == 0)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine("{0} {1}", mollysScore, dollysScore);
                    break;
                }
            }
        }
      
    }
}
