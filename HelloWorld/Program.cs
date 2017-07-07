using System;

namespace Conditionals
{
    public enum Season {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter picture width: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter picture height: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Please print picture in landscape mode.");
            }
            else
            {
                Console.WriteLine("Please print picture in portrait mode.");
            }
        }
    }
}