using System;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Context con = new Context();
            Console.WriteLine("what class is now, 1-DP 2-Soft Skills");
            int clas =Int32.Parse(Console.ReadLine());
            Console.WriteLine(clas);
            switch (clas)
            {
                case 1:
                    con.Strategy = new DesignPatternSession();
                    break;
                case 2:
                    con.Strategy = new SoftSkillsSession();
                    break;
            }
            con.executeStrategy();
        }
    }
}