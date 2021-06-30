using System;
using System.Collections.Generic;

namespace Strategy
{
    class Context
    {
        private IDiscountStrategy _strategy;
        
        public Context() {}
        
        public Context(IDiscountStrategy strategy)
        {
            this._strategy = strategy;
        }
        
        public void SetStrategy(IDiscountStrategy strategy)
        {
            this._strategy = strategy;
        }
        
        public double CalculateDiscount(double amount)
        {
            return _strategy.DiscountAmount(amount);
        }
    }
    
    public interface IDiscountStrategy
    {
        double DiscountAmount(double amount);
    }
    
    class SummerDiscount : IDiscountStrategy
    {
        public double DiscountAmount(double amount)
        {
            return amount * 0.5;
        }
    }

    class EidDiscount : IDiscountStrategy
    {
        public double DiscountAmount(double amount)
        {
            return amount * 0.9;
        }
    }

    class RamadanDiscount : IDiscountStrategy
    {
        public double DiscountAmount(double amount)
        {
            return amount * 0.6;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Summer discount this year");
            context.SetStrategy(new SummerDiscount());
            Console.WriteLine("Original price: 150sr");
            Console.WriteLine($"Price after discount: {context.CalculateDiscount(150)}sr");

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Eid discount this year");
            context.SetStrategy(new EidDiscount());
            Console.WriteLine("Original price: 54.66sr");
            Console.WriteLine($"Price after discount: {context.CalculateDiscount(54.66)}sr");
            
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Ramadan discount this year");
            context.SetStrategy(new RamadanDiscount());
            Console.WriteLine("Original price: 399.43sr");
            Console.WriteLine($"Price after discount: {context.CalculateDiscount(399.43)}sr");
        }
    }
}