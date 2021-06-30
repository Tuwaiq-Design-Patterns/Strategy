using System;
namespace Strategy_Design_Pattern
{
    public class Mada:PaymentMethod
    {
        public Mada()
        {
        }

        public bool pay(double amount)
        {
            if (amount <0) { return false; }

            Console.WriteLine("Mada");
            return true;
        }
    }
}
