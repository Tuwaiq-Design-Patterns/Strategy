using System;

namespace Strategy
{
    class Program
    {
        public interface IStrategy
        {
            public void processSpeeding();
        }

        public class NicePolice : IStrategy
        {
            public void processSpeeding()
            {
                Console.WriteLine("The police man was very nice and let you go without a fine");
            }
        }

        public class HardPolice : IStrategy
        {
            public void processSpeeding()
            {
                Console.WriteLine("The police fined you $50 for driving over the speed limit");
            }
        }

        public class Situation
        {
            private IStrategy strategy;

            public Situation(IStrategy strategy)
            {
                this.strategy = strategy;
            }

            public void setStrategy(IStrategy strategy)
            {
                this.strategy = strategy;
            }

            public void handleByPolice()
            {
                Console.WriteLine("Oh no! You were driving over the speed limit and a police man saw you");
                strategy.processSpeeding();
            }
        }


        static void Main(string[] args)
        {
            IStrategy nicePolice = new NicePolice();
            IStrategy hardPolice = new HardPolice();

            Situation situation = new Situation(nicePolice);
            situation.handleByPolice();

            Console.WriteLine("\nChanging Strategy to hardPolice\n");
            situation.setStrategy(hardPolice);
            situation.handleByPolice();
        }
    }
}
