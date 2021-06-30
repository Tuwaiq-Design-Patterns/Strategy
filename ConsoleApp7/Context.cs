using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp7.Strategy;

namespace ConsoleApp7
{
    public class StrategyContext
    {
        double price;
        Dictionary<string, IOffer> strategyContext = new Dictionary<string, IOffer>();
        public StrategyContext(double price)
        {
            this.price = price;

            strategyContext.Add(nameof(NoDiscount), new NoDiscount());
            strategyContext.Add(nameof(QuarterDiscount), new QuarterDiscount());
        }

        public void ApplyStrategy(IOffer strategy)
        {
            Console.WriteLine("Price before offer :" + price);

            double finalPrice = price - (price * strategy.GetDiscountPercentage());

            Console.WriteLine("Price after offer:" + finalPrice);
        }

        public IOffer GetStrategy(int MonthNumber)
        {
            if (MonthNumber < 6)
            {
                return strategyContext[nameof(NoDiscount)];
            }
            else
            {
                return strategyContext[nameof(QuarterDiscount)];
            }
        }
    }
}
