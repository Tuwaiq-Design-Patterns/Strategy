using System;
namespace Strategy_Design_Pattern
{
    public interface PaymentMethod
    {
        public bool pay(double amount);
    }
}
