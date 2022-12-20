using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_to_find_the_perfect_numbers_from_n1_to_n2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To run the program, click start without Debugging (Ctrl+F5)

            int sum, i, j;
            Console.Write("Enter First Number:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Secound Number:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(" Perfrct Number between the two Number is:");

            for (i = x; i < y; i++)

            {
                j = 1;
                sum = 0;
                while (j < i)
                {
                    if (i % j == 0)
                        sum += j; j++;

                }

                if (sum == i)

                    Console.WriteLine("{0}", i);

            }


        }
    }
}
