using System;
using System.Collections.Generic;

namespace StrategyDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext(100);
            Console.WriteLine("Enter month number between 1 and 12");
            var input = Console.ReadLine();
            int month = Convert.ToInt32(input);
            Console.WriteLine("Month =" + month);
            IOfferStrategy strategy = context.GetStrategy(month);
            context.ApplyStrategy(strategy);
            Console.ReadLine();
        }

    }

    public interface IOfferStrategy
    {
        string Name { get; }
        double GetDiscountPercentage();
    }
    class NoDiscountStratgy : IOfferStrategy
    {
        public string Name => nameof(NoDiscountStratgy);
        public double GetDiscountPercentage()
        {
            return 0;

        }
    }
    class QuarterDiscountStrategy : IOfferStrategy
    {
        public string Name => nameof(QuarterDiscountStrategy);

        public double GetDiscountPercentage()
        {
            return 0.25;
        }
    }
    class StrategyContext
    {
        double price;
        Dictionary<string, IOfferStrategy> strategyContext
            = new Dictionary<string, IOfferStrategy>();
        public StrategyContext(double price)
        {
            this.price = price;
            strategyContext.Add(nameof(NoDiscountStratgy),
                    new NoDiscountStratgy());
            strategyContext.Add(nameof(QuarterDiscountStrategy),
                    new QuarterDiscountStrategy());
        }

        public void ApplyStrategy(IOfferStrategy strategy)
        {
          
            Console.WriteLine("Price before offer :" + price);
            double finalPrice
                = price - (price * strategy.GetDiscountPercentage());
            Console.WriteLine("Price after offer:" + finalPrice);
        }

        public IOfferStrategy GetStrategy(int monthNo)
        {
            if (monthNo < 6)
            {
                return strategyContext[nameof(NoDiscountStratgy)];
            }
            else
            {
                return strategyContext[nameof(QuarterDiscountStrategy)];
            }
        }
        
       
    }

}
