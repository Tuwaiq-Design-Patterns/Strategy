using System;

namespace Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            IEncodingStrategy encodingStrategy = new RSAEncodingStrategy();
            Encoding encoding = new Encoding(encodingStrategy);
            encoding.Encode("10000011110");

            encodingStrategy = new DESncodingStrategy();
            encoding = new Encoding(encodingStrategy);
            encoding.Encode("10000011110");

            

        }
    }


    
    public interface IEncodingStrategy
    {
        void EncodeValue(string value);
    }

    public class RSAEncodingStrategy : IEncodingStrategy
    {
        public void EncodeValue(string value)
        {
            Console.WriteLine("Value "+ value + " is Encoded using RSA Algorithm");
        }
    }

    public class DESncodingStrategy : IEncodingStrategy
    {
        public void EncodeValue(string value)
        {
            Console.WriteLine("Value "+ value + " is Encoded using DES Algorithm");
        }
    }

  

    public class Encoding
    {
        private IEncodingStrategy _encodeStrategy;

        public Encoding(IEncodingStrategy encodeStrategy)
        {
            _encodeStrategy = encodeStrategy;
        }

        public void Encode(string value)
        {
            _encodeStrategy.EncodeValue(value);
        }
    }
}
