using System;

namespace StrategyDesignPattren
{

    public interface IStrategy
    {
        string GetDistanceTime(string source, string destination);
    }

    public class CarStrategy : IStrategy
    {
        public string GetDistanceTime(string source, string destination)
        {
            return "\nDistance time from " + source + " to " + destination + " by Car : 30 minutes";
        }
    }

    public class BikeStrategy : IStrategy
    {
        public string GetDistanceTime(string source, string destination)
        {
            return "\nDistance time from " + source + " to " + destination + " by Bike : 25 minutes";
        }
    }

    public class BusStrategy : IStrategy
    {
        public string GetDistanceTime(string source, string destination)
        {
            return "\nDistance time from " + source + " to " + destination + " by Bus : 40 minutes";
        }
    }

    public class TravelStrategy
    {
        private IStrategy _strategy;

        public TravelStrategy(IStrategy chosenStrategy)
        {
            _strategy = chosenStrategy;
        }

        public void GetDistanceTime(string source, string destination)
        {
            var result = _strategy.GetDistanceTime(source, destination);

            Console.WriteLine(result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome!");


            while (true) {

                Console.WriteLine("\nPlease select the type of transport to get the distance time between AlMarwah dist. to AlRawdah dist: \n\n1-Car , 2-Bike , 3-Bus , 4-exit");

                Console.WriteLine("\nEnter the type:");
                var userStrategy = Console.ReadLine();


                switch (userStrategy)
                {
                    case "1":
                        new TravelStrategy(new CarStrategy()).GetDistanceTime("Almarwah", "AlRawdah");
                        Console.WriteLine("\n---------------------------------------------------------------");
                        break;

                    case "2":
                        new TravelStrategy(new BikeStrategy()).GetDistanceTime("Almarwah", "AlRawdah");
                        Console.WriteLine("\n---------------------------------------------------------------");
                        break;

                    case "3":
                        new TravelStrategy(new BusStrategy()).GetDistanceTime("Almarwah", "AlRawdah");
                        Console.WriteLine("\n---------------------------------------------------------------");
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("invalid type of transport\nPlease select again:");
                        break;
                }
            }
        }

    }
}
