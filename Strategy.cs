using System;

namespace Strategy_DP
{

    public interface IStrategy
    {
        int getBill(int amount);
    }

    class HightDiscount : IStrategy
    {
        public int getBill(int amount)
        {
            return (int)(amount-(amount * 0.5));
        }
    }

    class LowDiscount : IStrategy
    {
        public int getBill(int amount)
        {
            return (int)(amount-(amount * 0.2));
        }
    }

    class NoDiscount : IStrategy
    {
        public int getBill(int amount)
        {
            return amount;
        }
    }
    class Context
    {
        private IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public int executeStrategy(int amount)
        {
            return _strategy.getBill(amount);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new HightDiscount());
            Console.WriteLine("Price after  Hight Discount: " + context.executeStrategy(100));

            context = new Context(new LowDiscount());
            Console.WriteLine("Price after  Low Discount:  " + context.executeStrategy(100));

            context = new Context(new NoDiscount());
            Console.WriteLine("Actual Price:  " + context.executeStrategy(100));
        }

    }
}
