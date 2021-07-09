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

            Console.WriteLine("This payment has been done by Visa");
            return true;
        }
    }
}
