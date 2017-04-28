using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program adds 10 to the number that you input ");
            Console.WriteLine("Please enter a number :");
            double number = double.Parse(Console.In.ReadLine()) + 10;
            Console.WriteLine("The result is: " + number);
            Console.WriteLine();

            Console.WriteLine("Now this program will add two numbers from the user");
            Console.WriteLine("Put in a number:");
            double input1 = double.Parse(Console.In.ReadLine());
            Console.WriteLine("Now enter the next number:");
            double input2 = double.Parse(Console.In.ReadLine());
            Console.WriteLine("The sum is: " + (input1 + input2));

        }
    }
}
