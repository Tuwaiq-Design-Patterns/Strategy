using System;

namespace Strategy
{
    public interface IStrategy
    {
        public int executionOperation(int NumberOne, int NumberTwo);
    }
    public class executionOperationAdd : IStrategy
    {

        public int executionOperation(int NumberOne, int NumberTwo)
        {
            return NumberOne + NumberTwo;
        }
        public class executionOperationSubstract : IStrategy
        {

            public int executionOperation(int NumberOne, int NumberTwo)
            {
                return NumberOne - NumberTwo;
            }
        }
        public class executionOperationMultiply : IStrategy
        {

            public int executionOperation(int NumberOne, int NumberTwo)
            {
                return NumberOne * NumberTwo;
            }
        }
        public class executionOperationDivision : IStrategy
        {

            public int executionOperation(int NumberOne, int NumberTwo)
            {
                return NumberOne / NumberTwo;
            }
        }
        public class Context
        {
            private IStrategy strategy;

            public Context(IStrategy strategy)
            {
                this.strategy = strategy;
            }

            public int executeStrategy(int NumberOne, int NumberTwo)
            {
                return strategy.executionOperation(NumberOne, NumberTwo);
            }
        }
        public class program
        {
            static void Main(string[] args)
            {
                Context context = new Context(new executionOperationAdd());
                Console.WriteLine("5 + 5 = " + context.executeStrategy(5, 5));

                context = new Context(new executionOperationSubstract());
                Console.WriteLine("5 - 5 = " + context.executeStrategy(5, 5));

                context = new Context(new executionOperationMultiply());
                Console.WriteLine("5 * 5 = " + context.executeStrategy(5, 5));
                context = new Context(new executionOperationDivision());

                Console.WriteLine("5 / 5 = " + context.executeStrategy(5, 5));
            }
        }
    }

}

