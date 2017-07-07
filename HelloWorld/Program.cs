using System;

namespace Conditionals
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("Thanks, " + input + "!");
            }
        }
    }
}