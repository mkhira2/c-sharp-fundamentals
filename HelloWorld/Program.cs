﻿using System;

namespace Conditionals
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}