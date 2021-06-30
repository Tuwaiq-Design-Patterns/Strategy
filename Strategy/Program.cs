using System;

namespace Strategy
{
    class StrategyExample
    {
        private IEncryption _encryption;

        public StrategyExample()
        { 
        
        }
        public StrategyExample(IEncryption encryption)
        {
            this._encryption = encryption;
        }
        public void SetStrategy(IEncryption encryption)
        {
            this._encryption = encryption;
        }
        public void Encryption()
        {
            Console.WriteLine("Calculating the size of the plaintext to choose which cipher strategy to be used.");

            this._encryption.Encrypt();


            Console.WriteLine("The encryption is finished.");
        }
    }
    public interface IEncryption
    {
        void Encrypt();
    }
    class LargeEncryption : IEncryption
    {
        public void Encrypt()
        {
            Console.WriteLine( "The text is large. Thus, we used the Large Encryption. \n"
                + 
                "The cipher is: \n"
                +
                "EnCt2bf28242eac7ddd543ce2bee79051a8e23849947fbf28242eac7ddd543ce2bee7UGVAYqFUAQF"
                );
        }
    }
    class SmallEncryption : IEncryption
    {
        public void Encrypt()
        {
            Console.WriteLine( "The text is short and therefore we used the Small Encryption. \n"
                +
                "The cipher is: \n"
                +
                "EnCt24c2034862311103d5b8ee374c4958e25527440314c2034862311103d5b8ee374qRo085q/AAK"
                );
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string messageShort = "Hello";
            Console.WriteLine("The plaintext is: " + messageShort);

            var strategy = new StrategyExample();

           
            strategy.SetStrategy(new SmallEncryption());
            strategy.Encryption();

            Console.WriteLine("\n\n\n");

            string message = "Hello, this is a plaintext message.";
            Console.WriteLine("The plaintext is: " + message);

            strategy.SetStrategy(new LargeEncryption());
            strategy.Encryption();
        }
    }
}
