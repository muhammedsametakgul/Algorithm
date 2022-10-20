using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //Define 2 variable to assign our last value
            int division = 0, remainder = 0;


            //Find the integer
            for (int i = 1; a > b; i++)
            {
                int c;
                a = a - b;
                division = i;
                c = a;
                //Find the number after ","
                if (a < b)
                {
                    c = 10 * c;
                    for (int j = 1; c > b; j++)
                    {
                        c -= b;
                        remainder = j;

                    }

                }


            }
            Console.WriteLine("Result is : " + division + "," + remainder);
            Console.ReadKey();
        }
    }
}
