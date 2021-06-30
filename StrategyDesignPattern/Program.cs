using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new();
            context.SetPaymentMethod(new MadaPayment());
            context.Pay();
            
            context.SetPaymentMethod(new VisaPayment());
            context.Pay();
            
            context.SetPaymentMethod(new MasterCardPayment());
            context.Pay();

        }
    }

    interface IPaymentMethod
    {
        public void Pay();
    }

    class MadaPayment : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Payed Through Mada");
        }
    }

    class VisaPayment : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Payed Through Visa");
        }
    }
    class MasterCardPayment : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Payed Through Master Card");
        }
    }

    class Context
    {
        private IPaymentMethod _paymentMethod;
        public Context(){}

        public Context(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }


        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void Pay()
        {
            _paymentMethod.Pay();
        }
    }
    
}