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
            string word = "hello"; // a string is an array (ordered sequence) of characters
            Console.Out.WriteLine(word);
            
            char character = 'c'; // a character is only 1 letter, digit, or symbol
            Console.Out.WriteLine(character);

            int integer = 24; // an integer is a number without a decimal and its range is between -2.14 billion and 2.14 billion
            Console.Out.WriteLine(integer);

            double number = 56.5; // a double is short for double precision floating point, it has more range it supports decimal values
            Console.Out.WriteLine(number);

            bool boolean = true; // boolean is true or false
            Console.Out.WriteLine(boolean);

            string word2 = "Tony";
            Console.Out.WriteLine(word + " " + word2); // this is called string concatenation which means to combine strings together

            Console.Out.WriteLine(word2 + " is number " + integer);
            Console.Out.WriteLine(integer + number); // when you add an integer with a double its result is a double
            Console.Out.WriteLine(integer / 5); // when you divide an integer with an integer, the result is still an integer, which truncates the decimal
            Console.Out.WriteLine(integer / 5.0); // when an integer is divided by a double, it will result in a double

            double result = 123 + 45 - 67 - 8 + 9;
            Console.Out.WriteLine(result);
            result = result + 10;
            Console.Out.WriteLine(result);

            double divisor = 35;
            Console.Out.WriteLine(result + " divided by " + divisor + " equals to " + result / divisor);

            /* I learned that i can add string and numbers together. I learned that there
             * are more types of variables, double, int, char and boolean.
             */

        }
    }
}
