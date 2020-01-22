using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE - create a List called "numbers"
            var numbers = new List<int>();

            //DONE - Create a variable of type int with an initializer of 0
            var i = 0;


            // DONE - create a do-while loop
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            // While your variable is less than 100
            do
            {
                i++;
                numbers.Add(i);

            } while (i < 100);


            // DONE - Create a while loop
            // While your variable is less than 200
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            while (i < 200)
            {
                i++;
                numbers.Add(i);
            }
//--------------------^^Added numbers to our Collection^^--------------
//----------------------All else now Prints those Numbers--------------

            Console.WriteLine("Increase:");


            // DONE Create a foreach loop
            // Write your variable to the console
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // DONE Create a for loop
            // in your initializer set the value of j to 199 (i already had a value set to it so we need a new one)
            // in your conditional, as long as j is less than or equal to the length of "numbers"
            // and as long as j is greater than or equal to 0
            // Decrement j by 1
            {
                // Write to the console "numbers" at index i
            }

            for (int j = 199; j <= numbers.Count && j >= 0; j--)
            {
                Console.WriteLine(numbers[j]);
            }
        }
    }
}
