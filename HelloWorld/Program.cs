using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            float price;
            if (isGoldCustomer) {
                price = 19.95f;
            else
                price = 29.95f
            */

            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;


            Console.WriteLine(price);
        }
    }
}