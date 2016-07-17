using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main()
        {
            // Ask user to enter a number
            Console.Write("Please enter a number: ");
            int numEntered = int.Parse(Console.ReadLine());

            // Validate number
            if (numEntered <= 0)
            {
                Console.Write("You must enter a positive number.");
                Console.WriteLine("Please try again.");
            }
            else
            {
                // Calculate the factorial, displaying each step
                int factorial = 1;
                for (int x = 1; x <= numEntered; x++)
                {
                    factorial *= x;
                    Console.WriteLine("{0}! = {1}", x, factorial);
                }
            }
            Console.ReadLine();
        }
    }
}
