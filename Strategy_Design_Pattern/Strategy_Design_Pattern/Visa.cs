using System;
namespace Strategy_Design_Pattern
{
    public class Visa:PaymentMethod
    {
        public Visa()
        {
        }

        public bool pay(double amount)
        {
            if (amount < 0) { return false; }

            Console.WriteLine("Visa");
            return true;
        }
    }
}
