using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // the result should be like 26/5 = 5 remainder 1
            // e.g. 23/5 = 4 remainder 3
            // hint: when you do integer divided by another integer, the result has no decimal part
            //     : e.g. 26/5 = 5
            //     : but when you do double division like: 26/5.0, the result is 5.2
            Console.WriteLine("Now this program will divide two numbers from the user");
            Console.WriteLine("Put in a number:");
            int input1 = int.Parse(Console.In.ReadLine());
            Console.WriteLine("Now enter the next number:");
            int input2 = int.Parse(Console.In.ReadLine());
            double number1 = (double)input1 / (double)input2;
            double decimalPart = number1 - input1 / input2;
            Console.WriteLine("The answer is: " + input1 / input2 + " remainder " + decimalPart * input2);
           

            // post-assignment note: the modulo operator '%' actually gives you (only) the remainder
            // e.g. 5 % 4 = 1
        }
    }
}
