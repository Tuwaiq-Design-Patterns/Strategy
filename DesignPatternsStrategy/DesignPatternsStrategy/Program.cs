using System;


namespace DesignPatternsStrategy
{
    
    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }
    
    public class ConcreteStrategyCar : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("You use car");
        }
    }
    
    public class ConcreteStrategyTrain : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("You use train");
        }
    }
    
    public class ConcreteStrategyBicycle : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("You use bicycle");
        }
    }
   
    public class Context
    {
        Strategy strategy;
        // Constructor
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Context context;
            //different strategies
            context = new Context(new ConcreteStrategyCar());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyTrain());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyBicycle());
            context.ContextInterface();
        }
    }
}
