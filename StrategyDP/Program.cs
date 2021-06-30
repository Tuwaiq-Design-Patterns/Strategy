using System;

namespace StrategyDP
{
    class Program
    {
        interface IPayment
        {
            public void pay();
        }

        class CreditCard : IPayment
        {
            public void pay()
            {
                Console.WriteLine("Credit Card");
            }
        }

        class Paypal : IPayment
        {
            public void pay()
            {
                Console.WriteLine("Paypal");
            }
        }

        class ShoppingCart
        {
            private IPayment payment;
            public ShoppingCart(IPayment payment) => this.payment = payment;
            public void SetPayment(IPayment payment) => this.payment = payment;
            public void pay() => payment.pay();
        }

        static void Main(string[] args)
        {
            var payment = new ShoppingCart(new CreditCard());
            payment.pay();
            payment.SetPayment(new Paypal());
            payment.pay();
       
        }
    }
}
