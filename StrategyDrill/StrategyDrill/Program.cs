using System;
using System.Collections.Generic;

namespace StrategyDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            var coach = new Coach(); 
            
            Console.WriteLine("Spacing Activated");
            coach.SetStrategy(new Spacing());
            coach.ExcuteStrategy();
            
            Console.WriteLine("Shooting Activated");
            coach.SetStrategy(new Shooting());
            coach.ExcuteStrategy();
            
            Console.WriteLine("Screeing Activated");
            coach.SetStrategy(new Screeing());
            coach.ExcuteStrategy();
            
            
        }
    }


    public class Coach
    {
        private IOffensiveBasketballStrategy _strategy;
        public Coach () {}
        public Coach(IOffensiveBasketballStrategy _strategy)
        {
            this._strategy = _strategy;
        }
        
        public void SetStrategy(IOffensiveBasketballStrategy strategy)
        {
            this._strategy = strategy;
        }    
        public void ExcuteStrategy()
        {
            _strategy.PrintStrategy();
        }
        
    }
    public interface IOffensiveBasketballStrategy
    {
        public void PrintStrategy(); 
    }

    public class Spacing : IOffensiveBasketballStrategy
    {
        public void PrintStrategy()
        {
            Console.WriteLine("Make spacing a priority");
        }
    }

    public class Shooting : IOffensiveBasketballStrategy
    {
        public void PrintStrategy()
        {
            Console.WriteLine("Best shooters shoot the most");
        }
    }


    public class Screeing : IOffensiveBasketballStrategy
    {
        public void PrintStrategy()
        {
            Console.WriteLine("Use Screens to Create Mismatches");
        }
    }
    
}

