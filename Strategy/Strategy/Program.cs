using System;

namespace Strategy
{
    interface TeachStrategy
    {
     public void Teach(string lesson);
    }

    class ThinkPairShare : TeachStrategy
{
        public void Teach(string lesson)
        {
            Console.WriteLine("\nApplying " + lesson + " Think -Pair -Share Strategy.");
        }
    }

    class BrainStorm : TeachStrategy
{
        public void Teach(string lesson)
        {
            Console.WriteLine("\nApplying " + lesson + " Brain Storming Strategy.");
        }
    }

    class ProblemSolve : TeachStrategy
{
        public void Teach(string lesson)
        {
            Console.WriteLine("\nApplying " + lesson + " Problem Solveing Strategy.");
        }
    }
    class TeachMethod
    {
        private string lesson;
        private TeachStrategy _teachStrategy;

        public void SetTeachStrategy(TeachStrategy teachStrategy)
        {
            this._teachStrategy = teachStrategy;
        }
        public void SetLesson(string name)
        {
            lesson = name;
        }
        public void Teach()
        {
           _teachStrategy.Teach(lesson);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TeachMethod teachMethod = new TeachMethod();

            Console.WriteLine("What is the lesson you want to teach?");
            var lesson = Console.ReadLine();
            teachMethod.SetLesson(lesson);

            Console.WriteLine("What teaching strategy would you like to use (1-3)?\n1-Think Pair Share Strategy\n2-Brain Storming Strategy\n3-Problem Solving Strategy\n");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    teachMethod.SetTeachStrategy(new ThinkPairShare());
                    teachMethod.Teach();
                    break;

                case 2:
                    teachMethod.SetTeachStrategy(new BrainStorm());
                    teachMethod.Teach();
                    break;

                case 3:
                    teachMethod.SetTeachStrategy(new ProblemSolve());
                    teachMethod.Teach();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();
        }
    }

}
       
