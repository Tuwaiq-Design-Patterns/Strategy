using System;

namespace strategy_dp
{
    class Context
    {
        public void CalculateDriverRate(IStratgey stratgey)
        {
            stratgey.CalculateDriverRate(2,4);
        }

    }

    public interface IStratgey
    {
       

        public void CalculateDriverRate(int radius, decimal rate);
        
        
    }

    public class UberEatsBicycle : IStratgey
    {

        public decimal bikeRate;
        public int radius;
        public decimal originalRate;

        public UberEatsBicycle(int radius)
        {
            this.bikeRate = 6;
            this.originalRate = 4;
            this.radius = radius;
        }

        public void CalculateDriverRate(int radius, decimal rate)
        {
            if(radius <= 2)
            {
                Console.WriteLine("You are using Uber Eats Bicycle:");
                Console.WriteLine("You Are Paid Extra $ {0} Of The Original Rate, \nYour total payment is: $ {1} \n", bikeRate,(bikeRate+originalRate));
            }
            else
            {
                Console.WriteLine("You Are Paid Regular Rate $ {0}", originalRate);
            }
            
        }
    }

    public class UberEatsCar : IStratgey
    {
        public int radius;
        public decimal originalRate;

        public UberEatsCar(int radius)
        {
            this.originalRate = 4;
            this.radius = radius;
        }

        public void CalculateDriverRate(int radius, decimal rate)
        {
            radius = 0;
            Console.WriteLine("You are using Uber Eats Car:");
            Console.WriteLine("You Are Paid $ {0}", originalRate);
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Context context = new Context();
            
            context.CalculateDriverRate(new UberEatsBicycle(2));

            
            context.CalculateDriverRate(new UberEatsCar(2));

            
        }
    }
}
