using System;
using System.Collections.Generic;

using ConsoleApp7.Strategy;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext(100);

            Console.WriteLine("Enter month number between 1 and 12");

            var input = Console.ReadLine();
            int month = Convert.ToInt32(input);

            Console.WriteLine("Month =" + month);

            IOffer strategy = context.GetStrategy(month);
            context.ApplyStrategy(strategy);

            Console.ReadLine();
        }
    }
}
