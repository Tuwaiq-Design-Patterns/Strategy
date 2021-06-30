using System;

namespace strategyPattern
{
    public interface Strategy
    {
        public float CalculateTax(float num);
    }
    public class KSATax : Strategy
    {
        public float CalculateTax(float num)
        {
            return (num * 5) / 100;
        }
    }
    public class USATax : Strategy
    {
        public float CalculateTax(float num)
        {
            return (num * 6.50f)/100;
        }
    }
    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public float executeStrategy(float num)
        {
            return strategy.CalculateTax(num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float price = 100.5f;
            Context context = new Context(new KSATax());
            Console.WriteLine("Before Tax Price: 100.00 SR \n Sale Tax (5%) : " + context.executeStrategy(price)+ " SR \n  After Tax Price: " + (context.executeStrategy(price) + price)+" SR");

            context = new Context(new USATax());
            Console.WriteLine("Before Tax Price: $100.00 \n Sale Tax (6.50%) : $" + context.executeStrategy(price) + "\n  After Tax Price: $" + (context.executeStrategy(price) + price));


        }
    }
}
