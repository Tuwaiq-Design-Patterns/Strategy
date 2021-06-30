using System;

namespace StrategyDesignPattern
{
    class Program
    {
        interface ITactic
        {
            public void RunTactic();
        }

        class TacticA : ITactic
        {
            public void RunTactic()
            {
                Console.WriteLine("This is Tactic A");
            }
        }

        class TacticB : ITactic
        {
            public void RunTactic()
            {
                Console.WriteLine("This is Tactic B");
            }
        }

        class Player
        {
            private ITactic tactic;
            public Player(ITactic tactic) => this.tactic = tactic;
            public void SetTactic(ITactic tactic) => this.tactic = tactic;
            public void Play() => tactic.RunTactic();
        }

        static void Main(string[] args)
        {
            var player = new Player(new TacticA());
            player.Play();
            player.SetTactic(new TacticB());
            player.Play();
        }
    }
}
