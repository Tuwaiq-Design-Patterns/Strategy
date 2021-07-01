using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public interface IBehaviour
    {
        public int moveCommand();
    }

    public class AttackBehaviour : IBehaviour
    {
        public int moveCommand()
        {
            Console.WriteLine("\tAttack Behaviour: if find another Player attack it");
            return 1;
        }
    }

    public class RunBehaviour : IBehaviour
    {
        public int moveCommand()
        {
            Console.WriteLine("\tRun Behaviour: if find another Player try to attack you run from it");
            return -1;
        }
    }

   

    public class Program
    {

        public static void Main(String[] args)
        {

            Player r1 = new("Robn Player1");
            Player r2 = new("Sara Player2");

            r1.setBehaviour(new AttackBehaviour());
            r2.setBehaviour(new RunBehaviour());

            r1.move();
            r2.move();


            r1.setBehaviour(new RunBehaviour());
            r2.setBehaviour(new AttackBehaviour());

            r1.move();
            r2.move();
        }
    }
}