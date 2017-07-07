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
            var season = Season.Summer;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion.");
                    break;

                default:
                    Console.WriteLine("No current promotions.");
                    break;
            }
        }
    }
}