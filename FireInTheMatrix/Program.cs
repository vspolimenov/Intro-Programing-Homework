using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireInTheMatrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the fire matrix : ");
            int size = int.Parse(Console.ReadLine());
            char[,] fireMatrix = new char[size -size/4, size];
            int fire = size/2 - 1 ;
            for (int i = 0; i < size - size / 4; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j == fire) || j == fire + 2*i + 1)
                    {
                        fireMatrix[i, j] = '#';
                    }
                    else
                    {
                        fireMatrix[i, j] = '.';
                    }
                    Console.Write(fireMatrix[i, j]);
                    
                    
                }
                if (fire > 0)
                {
                    fire--;
                }
                else if(fire <= 0)
                {
                    break;
                   
                }
                Console.WriteLine();

            }
            fire = 0;
            Console.WriteLine();
            for (int i = 0; i < size - size / 4; i++)
            {   
                for (int j = 0; j < size; j++)
                {
                    if ((j == fire) || j ==( size - 1 - fire))
                    {
                        fireMatrix[i, j] = '#';
                    }
                    else
                    {
                        fireMatrix[i, j] = '.';
                    }
                    Console.Write(fireMatrix[i, j]);


                }
                if (fire < size/4 -1)
                {
                    fire++;
                }
                else 
                {
                    break;

                }
                Console.WriteLine();

            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write('-');
            }
            fire = size / 2;
            Console.WriteLine();
            for (int i = 0; i <size / 2; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j < size/2) && j >= i )
                    {
                        fireMatrix[i, j] = '\\';
                    }
                    else if(j >= size/2 && j<= size -i-1)
                    {
                        fireMatrix[i, j] = '/';
                    }
                    else
                    {
                        fireMatrix[i, j] = '.';
                    }
                    Console.Write(fireMatrix[i, j]);
                    


                }
                
                
                    fire++;
                
               
                Console.WriteLine();

            }
        }
    }
}
