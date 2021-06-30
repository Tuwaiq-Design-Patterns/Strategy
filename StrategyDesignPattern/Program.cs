using System;

namespace Strategy.Structural
{
  

    public class Program
    {
        public static void Main(string[] args)
        {
            Context strategy1;
            Context strategy2;

            strategy1 = new Context(new OffensiveStrategy());
            strategy1.ContextInterface();

            strategy2 = new Context(new DefensiveStrategy());
            strategy2.ContextInterface();

        }
    }

  

    public abstract class Strategy
    {
        public abstract void TeamFormation();
    }


    public class OffensiveStrategy : Strategy
    {
        public override void TeamFormation()
        {
            Console.WriteLine("3-4-3 Formation - Offensive Formation");
        }
    }

    public class DefensiveStrategy : Strategy
    {
        public override void TeamFormation()
        {
            Console.WriteLine("5-4-1 Formation - Defensive Formation");
        }
    }

    public class Context
    {
        Strategy FormationStrategy;


        public Context(Strategy FormationStrategy)
        {
            this.FormationStrategy = FormationStrategy;
        }

        public void ContextInterface()
        {
            FormationStrategy.TeamFormation();
        }
    }
}
