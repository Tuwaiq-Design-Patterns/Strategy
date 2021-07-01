using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Player
    {
        IBehaviour behaviour;
        string name;

        public Player(string name)
        {
            this.name = name;
        }

        public void setBehaviour(IBehaviour behaviour)
        {
            this.behaviour = behaviour;
        }

        public IBehaviour getBehaviour()
        {
            return behaviour;
        }

        public void move()
        {
            int command = behaviour.moveCommand();
            Console.WriteLine("\t the Player '" + this.name + "'");
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
