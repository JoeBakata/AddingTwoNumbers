using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTwoNumbers
{
    class Program
    {
        // Change and running.
        // Change number 3

        static void Main(string[] args)
        {

            // Print name, version and name of creator in blue.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tAddingTwoNumbers\tVer 1.0\tcreated by JB");

            // Console foreground color back to default.
            Console.ForegroundColor = ConsoleColor.Gray;

            // Ask the user for the first number.
            Console.WriteLine("Please enter the first Addend (number)."); // Writes the string that is entered in the quotes inside the parenthesis.

            double // Double is a float, allowing the use of decimal numnbers.

                firstAugend // Name of the variable to store the first number in. The one to which the others are added, is sometimes called the augend.

                = Convert.ToDouble // Used to convert a string to a double.

            // Get the number from the user.
                (Console.ReadLine()); // Reads input from the console. Console input is a string.

            // Ask the user for the second number.
            Console.WriteLine("Please enter the second Addend (number).");

            // Create a variable to store that number. Remember to convert it from a string to a double.
            double firstAddend = double.Parse(Console.ReadLine());// Better to use double.Parse or Convert.ToDouble?

            // Create a variable to store the answer in.
            double sum;

            // Create the equation, which gets evaluated and then stores the result in the variable.
            sum = firstAugend + firstAddend;

            // Change the console foreground color to green.
            Console.ForegroundColor = ConsoleColor.Green;

            // Show the user the answer in green.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" When you take {firstAugend} and add {firstAddend} to it\n you get {sum} which is called the Sum.");

            // Keep the console open.
            Console.ReadKey();
           
            // todo1 why does it do the program twice before closing? it happens because I used Console.ReadLine instead of Console.Read?
            // todo2 make a way for the program to continue.
            // todo3 make a way to exit the program.
            // todo4 check for valid input
            
        }
    }
}
