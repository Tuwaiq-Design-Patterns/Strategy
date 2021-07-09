using System;

namespace Strategy_Design_Pattern
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Payment method available:  Paypal,Cash and Visa");
            Console.Write("Enter your  Payment method: ");
            String UserInput = Console.ReadLine();
            PaymentMethod payment;

            if (UserInput.ToLower() == "paypal")
            {

                payment = new PayPal();
                payment.pay(123);
            }
            else if (UserInput.ToLower() == "cash")
            {
                payment = new Cash();
                payment.pay(123);
            }
            else if (UserInput.ToLower() == "visa")
            {
                payment = new Visa();
                payment.pay(123);
            }
            else
            {
                Console.WriteLine("Not available");
            }


        }
    }
}
