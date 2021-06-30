using System;

namespace strategy
{
    public class Context
    {
        private IStrategyToBeatMansourInTheBilliards _strategy;
        public Context() { }
        public Context(IStrategyToBeatMansourInTheBilliards _strategy)
        {
            this._strategy = _strategy;
        }

        public void SetStrategy(IStrategyToBeatMansourInTheBilliards strategy)
        {
            this._strategy = strategy;
        }
        public void ExcuteStrategy()
        {
            _strategy.DoAlgorithm();
        }

    }

    public interface IStrategyToBeatMansourInTheBilliards
    {
        public void DoAlgorithm();
    }
    class Distraction : IStrategyToBeatMansourInTheBilliards
    {
        public void DoAlgorithm()
        {
            Console.WriteLine("Distracting Mansour by talking to him about things that bother him");
        }
    }

    class Cheating : IStrategyToBeatMansourInTheBilliards
    {
        public void DoAlgorithm()
        {
            Console.WriteLine("Drop some balls while he's busy");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Distraction Strategy");
            context.SetStrategy(new Distraction());
            context.ExcuteStrategy();
            Console.WriteLine();

            Console.WriteLine("Cheating Strategy");
            context.SetStrategy(new Cheating());
            context.ExcuteStrategy();
        }
    }
}