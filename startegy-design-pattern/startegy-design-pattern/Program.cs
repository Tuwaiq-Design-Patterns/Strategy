using System;
using System.Collections.Generic;

namespace startegy_design_pattern
{
    // The Context defines the interface of interest to clients.
    class Context
    {
        private IDiscount _strategy;

        public Context()
        { }

       
        public Context(IDiscount strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IDiscount strategy)
        {
            this._strategy = strategy;
        }

        public void ApplyDiscount()
        {
            Console.WriteLine("Before discount: 39.75");
            var result = this._strategy.DiscountValue(39.75);
            Console.WriteLine(result);
        }
    }

    public interface IDiscount
    {
        double DiscountValue(double data);
    }

    class EidDiscount : IDiscount
    {
        public double DiscountValue(double data)
        {
            //15% off
            return data - (data * 0.15);
        }
    }

    class SummerDiscount : IDiscount
    {
        public double DiscountValue(double data)
        {
            //40% off
            return data - (data * 0.40);
        }
    }

    class BTSDiscount : IDiscount
    {
        public double DiscountValue(double data)
        {
            //70% off
            return data - (data * 0.70);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var context = new Context();

            Console.WriteLine("Eid discount (15% off)");
            context.SetStrategy(new EidDiscount());
            context.ApplyDiscount();

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Summer discount (40% off)");
            context.SetStrategy(new SummerDiscount());
            context.ApplyDiscount();

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Back to school discount (70% off)");
            context.SetStrategy(new BTSDiscount());
            context.ApplyDiscount();
        }
    }
}
