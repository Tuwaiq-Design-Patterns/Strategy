using System;

namespace StrategyPractice
{

    public interface IAttack
    {
        public void attack();

    }

    //strategy 1
    public class ShortRangeAttack : IAttack
    {
        public void attack()
        {
            Console.WriteLine("punch.....");
        }
    }

    //strategy 2
    public class MidRangeAttack : IAttack
    {
        public void attack()
        {
            Console.WriteLine("Boom!!!!!!!");
        }
    }

    //strategy 3
    public class LongRangeAttack : IAttack
    {
        public void attack()
        {
            Console.WriteLine("LAZER! PEW PEW ----------------");
        }
    }


    public class Player
    {
        public string name;
        public IAttack attackBehaviour;

        public Player(string name ,IAttack attack)
        {
            this.name = name;
            this.attackBehaviour = attack;
        }

        public void executeAttack()
        {
            this.attackBehaviour.attack();
        }

        public void SetAttack(IAttack attack)
        {
            this.attackBehaviour = attack;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Mohammed", new ShortRangeAttack());
            player.executeAttack();

            Console.WriteLine("Enemy GOT AWAY!");
            player.SetAttack(new LongRangeAttack());
            player.executeAttack();
            player.executeAttack();

            Console.WriteLine("Enemy is getting close!");
            player.SetAttack(new MidRangeAttack());
            player.executeAttack();


        }
    }
}
