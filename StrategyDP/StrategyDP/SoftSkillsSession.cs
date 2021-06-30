using System;

namespace StrategyDP
{
    public class SoftSkillsSession:IStrategy
    {
        public void execute()
        {
            Console.WriteLine("Sleep or Ask for a break");
        }
    }
}