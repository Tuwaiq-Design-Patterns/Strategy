using System;

namespace Stratigy_Design_Pattern
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Player Player;

            Player = new Player(new Fork());
            Player.PlayerInterface();

            Player = new Player(new Pin());
            Player.PlayerInterface();

            Player = new Player(new Skewer());
            Player.PlayerInterface();
        }
    }

    public abstract class Strategy
    {
        public abstract void Algorithm();
    }

    public class Fork : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine(
                "Called Fork.Algorithm()");
        }
    }

    public class Pin : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine(
                "Called Pin.Algorithm()");
        }
    }

    public class Skewer : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine(
                "Called Skewer.Algorithm()");
        }
    }


    public class Player
    {
        Strategy strategy;

        public Player(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void PlayerInterface()
        {
            strategy.Algorithm();
        }
    }
}
