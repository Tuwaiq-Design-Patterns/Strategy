

namespace Strategy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Strategy
    {
        abstract class CookStrategy
        {
            public abstract void Cook(string food);
        }
        
        class Grilling : CookStrategy
        {
            public override void Cook(string food)
            {
                Console.WriteLine("\nCooking " + food + " by grilling it.");
            }
        }

        
        class OvenBaking : CookStrategy
        {
            public override void Cook(string food)
            {
                Console.WriteLine("\nCooking " + food + " by oven baking it.");
            }
        }
        
        
        class DeepFrying : CookStrategy
        {
            public override void Cook(string food)
            {
                Console.WriteLine("\nCooking " + food + " by deep frying it");
            }
        }
        
        
        class Context
        {
            private string Food;
            private CookStrategy _cookStrategy;

            public void SetCookStrategy(CookStrategy cookStrategy)
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
    }
}