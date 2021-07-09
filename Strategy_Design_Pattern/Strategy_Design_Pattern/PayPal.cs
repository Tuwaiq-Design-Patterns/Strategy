using System;
namespace Strategy_Design_Pattern
{
    public class PayPal:PaymentMethod
    {
        public PayPal()
        {
        }

        public bool pay(double amount)
        {
            if (amount < 0) { return false; }

            Console.WriteLine("This payment has been done by PayPal");
            return true;
        }
    }
}
