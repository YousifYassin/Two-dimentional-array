using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] number = new int[3,3];

            number[0, 0] = 1;
            number[0, 1] = 2;
            number[0, 2] = 3;
            ////////////////////////
            number[1, 0] = 4;
            number[1, 1] = 5;
            number[1, 2] = 6;
            /////////////////////////
            number[2, 0] = 7;
            number[2, 1] = 8;
            number[2, 2] = 9;
            /////////////////////////
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(number[i , j] + "\t");
                    if ((j+1) % 3 ==0)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
        static int Input()
        {
            Console.WriteLine("Please insert your value");

            while (true)
            {
                int convInput;
                string value = Console.ReadLine();
                if (Int32.TryParse(value,out convInput))
                {
                    return convInput;
                }
                else
                {
                    Console.WriteLine("please try again using number!!");
                }

            }
        }
    }
}
