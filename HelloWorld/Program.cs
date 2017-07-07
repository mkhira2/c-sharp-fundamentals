using System;

namespace Conditionals
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            int value;

            if (int.TryParse(input, out value))
            {
                Console.WriteLine(input);
            }
            else {
                Console.WriteLine("That's not a number!");
            }
        }
    }
}