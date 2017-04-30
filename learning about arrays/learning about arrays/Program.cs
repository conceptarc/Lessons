using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_about_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // examples of how to create arrays
            int[] numbers1;
            numbers1 = new int[10];
            int[] numbers2 = new int[10];

            double[] numerals1;
            numerals1 = new double [20];

            float[] floatArray;
            floatArray = new float[20];
            ////////////////////////////////////

            int[] intArray = new int[5];
            intArray[0] = -103;
            intArray[1] = -98;
            intArray[2] = -97;
            intArray[3] = -96;
            intArray[4] = -95;
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            int temp = intArray[0];
            intArray[0] = intArray[4];
            intArray[4] = temp; 
            Console.WriteLine();
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine();

            int sum = intArray[0] + intArray[1] + intArray[2] + intArray[3] + intArray[4];
            Console.WriteLine("The average is: " + sum / 5.0);

            // I learned how to assign an array a value and do calculations with it.
            // To swap a value you require a variable to store a value.
            // An index is the number of the place in the array.
            

        }
    }
}
