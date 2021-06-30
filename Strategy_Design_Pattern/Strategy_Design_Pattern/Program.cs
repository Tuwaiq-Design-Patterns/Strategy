using System;

namespace Strategy_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod payment = new PayPal();

            payment.pay(123);
        }
    }
}
