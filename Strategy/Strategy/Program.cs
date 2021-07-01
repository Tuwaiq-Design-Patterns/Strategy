using System;
using Strategy.Strategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            context.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());
            

            switch(input)
            {
                case 1:
                    context.SetCookStrategy(new Grilling());
                    context.Cook();
                    break;

                case 2:
                    context.SetCookStrategy(new OvenBaking());
                    context.Cook();
                    break;

                case 3:
                    context.SetCookStrategy(new DeepFrying());
                    context.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
        }
    }
}