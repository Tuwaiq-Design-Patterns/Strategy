using System;

namespace Strategy
{

    class Program
    {
        public interface Worker
    {
        public string work();
    }

    public class Programmer : Worker
        {
            public string work()
            {
                return "Programmer";
            }

        }

        public class Designer : Worker
        {
            public string work()
            {
                return "Designer";

            }
        }
    public class Maneger : Worker
        {
            public string work()
            {
                return "Maneger";

            }
        }
    public class Context
    {
        private Worker strategy;

        public Context(Worker strategy)
        {
            this.strategy = strategy;
        }

        public string executeStrategy()
        {
            return strategy.work();
        }
    }

   
        static void Main(string[] args)
        {
            Context context = new Context(new Designer());
            Console.WriteLine("Worker:" + context.executeStrategy());

            context = new Context(new Programmer());
            Console.WriteLine("Worker: " + context.executeStrategy());

            context = new Context(new Maneger());
            Console.WriteLine("Worker: " + context.executeStrategy());
        }
    }
}
