using System;

namespace Strategy
{
    class Context
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IDiscount _discount;

        public Context()
        { }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Context(IDiscount discount)
        {
            this._discount = discount;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetDiscount(IDiscount discount)
        {
            this._discount = discount;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public double CalcDiscount(double amount)
        {
            return this._discount.ApplyDiscount(amount);
        }
    }

    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.
    public interface IDiscount
    {
        double ApplyDiscount(double amount);
    }

    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    class EidDiscount : IDiscount
    {
        public double ApplyDiscount(double amount)
        {
            return amount-(amount * 0.30);
        }
    }

    class RamadanDiscount : IDiscount
    {
        public double ApplyDiscount(double amount)
        {
            return amount-(amount * 0.50);
        }
    }

    class SummerDiscount : IDiscount
    {
        public double ApplyDiscount(double amount)
        {
            return amount-(amount * 0.25);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();
            double amount = 200;
            Console.WriteLine($"Original Price: {amount}\n");
            context.SetDiscount(new EidDiscount());
            Console.WriteLine($"Discount for Eid at this time of the year\nNew Price:{context.CalcDiscount(amount)}\n");

            context.SetDiscount(new RamadanDiscount());
            Console.WriteLine($"Discount for Ramadan at this time of the year\nNew Price:{context.CalcDiscount(amount)}\n");

            context.SetDiscount(new SummerDiscount());
            Console.WriteLine($"Discount for Summer at this time of the year\nNew Price:{context.CalcDiscount(amount)}\n");

        }
    }
}
