using System;

namespace StrategyDP
{
    public class DesignPatternSession : IStrategy
    {
        public void execute()
        {
            Console.WriteLine("Focuses and have fun");
        }
    }
}