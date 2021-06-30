using System;

namespace STRATEGY
{
    class Program
    {

        interface IStrategy
        {
            public int DisCount(int bill);

        }
        class Eid : IStrategy
        {
            public int DisCount(int bill)
            {
                int total = bill - (bill * 20 / 100);
                return total;
            }
        }
        class Ramadan : IStrategy
        {
            public int DisCount(int bill)
            {
                int total = bill - (bill * 15 / 100);
                return total;
            }
        }
        class BackToSchool : IStrategy
        {
            public int DisCount(int bill)
            {
                int total = bill - (bill * 25 / 100);
                return total;
            }
        }
        static void Main(string[] args)
        {
            Eid e = new Eid();
            Console.WriteLine("Total price after Apply Eid Discount :" + e.DisCount(200) + ".SR");
            Ramadan r = new Ramadan();
            Console.WriteLine("Total price after Apply Ramadan Discount :" + r.DisCount(200) + ".SR");
            BackToSchool b = new BackToSchool();
            Console.WriteLine("Total price after Apply Back to school Discount :" + b.DisCount(200) + ".SR");

        }
    }
}
