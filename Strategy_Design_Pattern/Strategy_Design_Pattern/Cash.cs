using System;
namespace Strategy_Design_Pattern
{
    public class Cash : PaymentMethod
    {
        public Cash()
        {
        }

        public bool pay(double amount)
        {
            if (amount <0) { return false; }

            Console.WriteLine("This payment has been done by Cash");
            return true;
        }
    }
}
