using System;

namespace Strategy
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

        public void WeopenBuilder()
        {
            Console.WriteLine("Black smith You're weopen");
            this._strategy.WeopenBuilder();
        }
    }

    public interface IStrategy
    {
        void WeopenBuilder();
    }

    class SwordMaker : IStrategy
    {
        public void WeopenBuilder()
        {
			Console.WriteLine("Here's your Sword");
            
            Console.WriteLine("\t\t\t   *\t\t\t");
            Console.WriteLine("\t\t\t* *** *\t\t\t");
            Console.WriteLine("\t\t\t* *** *\t\t\t");
            Console.WriteLine("\t\t\t *****\t\t\t");
            Console.WriteLine("\t\t\t *****\t\t\t");
            Console.WriteLine("\t\t\t *****\t\t\t");
            Console.WriteLine("\t\t\t *****\t\t\t");
            Console.WriteLine("\t\t\t *****\t\t\t");
            Console.WriteLine("\t\t\t *****\t\t\t");
            Console.WriteLine("\t\t\t *****\t\t\t");
            Console.WriteLine("\t\t      ***********\t\t");
            Console.WriteLine("\t\t\t******\t\t\t");
            Console.WriteLine("\t\t\t******\t\t\t");
            Console.WriteLine("\t\t\t******\t\t\t");
            Console.WriteLine("\t\t\t******\t\t\t");
        }
    }

    class DaggersMaker : IStrategy
    {
        public void WeopenBuilder()
        {
            Console.WriteLine("Here's your Daggers");
            Console.WriteLine("\t\t\t *\t\t\t \t\t\t *\t\t\t");
            Console.WriteLine("\t\t\t***\t\t\t \t\t\t***\t\t\t");
            Console.WriteLine("\t\t\t***\t\t\t \t\t\t***\t\t\t");
            Console.WriteLine("\t\t\t***\t\t\t \t\t\t***\t\t\t");
            Console.WriteLine("\t\t\t***\t\t\t \t\t\t***\t\t\t");
            Console.WriteLine("\t\t\t***\t\t\t \t\t\t***\t\t\t");
            Console.WriteLine("\t\t      ********\t\t \t\t\t      ********\t\t");
            Console.WriteLine("\t\t\t***\t\t\t \t\t\t***\t\t\t");
            Console.WriteLine("\t\t\t***\t\t\t \t\t\t***\t\t\t");
            
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            Console.WriteLine();

            context.SetStrategy(new SwordMaker());
            context.WeopenBuilder();

            Console.WriteLine();

            context.SetStrategy(new DaggersMaker());
            context.WeopenBuilder();
        }
    }
}
