using System;
using System.Collections.Generic;

namespace StrategyDesignPatterns
{
    class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void BuildHouse()
        {
            Console.WriteLine("Building your house...");
            this._strategy.BuildHouse();
        }
    }

    public interface IStrategy
    {
        void BuildHouse();
    }

    class OneFloorHouse : IStrategy
    {
        public void BuildHouse()
        {
			Console.WriteLine("Here's your one floor house");
            Console.WriteLine("************");
            Console.WriteLine("*          *");
            Console.WriteLine("************");
        }
    }

    class TwoFloorHouse : IStrategy
    {
        public void BuildHouse()
        {
            Console.WriteLine("Here's your two floors house");
            Console.WriteLine("************");
            Console.WriteLine("*          *");
            Console.WriteLine("************");
            Console.WriteLine("*          *");
            Console.WriteLine("************");
        }
    }

    class Program
	{
		static void Main(string[] args)
		{
           
            var context = new Context();
            Console.WriteLine();

            context.SetStrategy(new OneFloorHouse());
            context.BuildHouse();

            Console.WriteLine();

            context.SetStrategy(new TwoFloorHouse());
            context.BuildHouse();
        }
	}
}
