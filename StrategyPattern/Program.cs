using System;

namespace StrategyPattern
{
    public class Context
    {
        private IPaymentStartegy paymentStartegy;


        public void pay(IPaymentStartegy paymentMethod)
        {
            paymentMethod.Pay(50);
        }
    }

    public interface IPaymentStartegy
    {
        public void Pay(decimal amount);
    }

    public class MadaStartegy : IPaymentStartegy
    {
        private string OwnerName;
        private int cardNumber;
        private string dateOfExpiry;
        private int cvv;

        public void Pay(decimal amount)
        {
            Console.WriteLine(amount + " paid with Mada");
        }

        public MadaStartegy(string name, int cardNumber, string dateOfExpiry, int cvv)
        {
            this.OwnerName = name;
            this.cardNumber = cardNumber;
            this.dateOfExpiry = dateOfExpiry;
            this.cvv = cvv;
        }
    }

    public class CashStartegy : IPaymentStartegy
    {
        
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount + " paid with Cash");
        }

        public CashStartegy()
        {

        }
    }

    public class PayPalStartegy : IPaymentStartegy
    {
        private string userEmail;
        private string userpassword;

        public void Pay(decimal amount)
        {
            Console.WriteLine(amount + " paid with PayPal");
        }

        public PayPalStartegy(string email, string password)
        {
            this.userEmail = email;
            this.userEmail = password;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.pay(new PayPalStartegy("rawabe44u@rawabe.com", "122RR$"));
            context.pay(new MadaStartegy("RAWABI", 12345678, "2023/01/01", 566));
        }
    }
}
