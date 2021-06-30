using System;

namespace StrategyPattern
{
    class Cooking
    {
        private string Food;
        private ICookStrategy _cookStrategy;

        public void SetCookStrategy(ICookStrategy cookStrategy)
        {
            this._cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }

    public interface ICookStrategy
    {
        public void Cook(string food);
    }


    class GrillingStrategy : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    class OvenBakingStrategy : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by baking it in the oven.");
        }
    }
    class DeepFryingStrategy : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var cooking = new Cooking();

            Console.WriteLine("What dish would you like to have?");
            var food = Console.ReadLine();
            cooking.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    cooking.SetCookStrategy(new GrillingStrategy());
                    cooking.Cook();
                    break;

                case 2:
                    cooking.SetCookStrategy(new OvenBakingStrategy());
                    cooking.Cook();
                    break;

                case 3:
                    cooking.SetCookStrategy(new DeepFryingStrategy());
                    cooking.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
