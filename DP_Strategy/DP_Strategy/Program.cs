using System;
using System.Collections.Generic;

namespace DP_Strategy
{

        class Context
        {
            private IStrategyMood _strategy;

            public Context(){
                _strategy = new DefaultMood();
            }
            
            public void SetStrategy(IStrategyMood strategy)
            {
                this._strategy = strategy;
            }

            public void PrintMessageByStrategy(string message)
            {
                Console.WriteLine("Context: Printing a message using the strategy (not sure how it'll be prented!)");

                 this._strategy.PrintMessage(message);
            }
        }




        public interface IStrategyMood
        {
            void PrintMessage(string data);
        }


        class DefaultMood : IStrategyMood
        {
            public void PrintMessage(string data)
            {
                var list = data.Split("\n");
                foreach (var line in list)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("\n");
        }
    }

        class ColorfulMood : IStrategyMood
        {
            public void PrintMessage(string data)
            {
                var list = data.Split(" ");
                ConsoleColor[] colors = { ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Blue , ConsoleColor.Green};
                
                foreach (var line in list)
                {
                    Random rndm = new Random();
                    Console.ForegroundColor = colors[rndm.Next(0,4)];
                    Console.Write(line +" ");
                }
                Console.WriteLine();
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                var context = new Context();

                string message = "Greeting all, I have no Idea of which color I am using. \n" +
                     "All I know is that I am printing this message. \n" +
                     "Fun fact: you may get a diff color each time you run the program (: \n" +
                     "GitHub: @1Riyad";

                Console.WriteLine("Client: Strategy is set to the normal color of the command line (defualt)");
                Console.WriteLine("--------------------");
                //ntext.SetStrategy(new DefaultMood());
                context.PrintMessageByStrategy(message);


                Console.WriteLine("Client: Strategy is set to the colorful mood");
                Console.WriteLine("--------------------");
                context.SetStrategy(new ColorfulMood());
                context.PrintMessageByStrategy(message);
            }
        }
    

}
