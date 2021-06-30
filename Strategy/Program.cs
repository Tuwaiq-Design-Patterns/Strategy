using System;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NormalDuck normalDuck = new NormalDuck(new DuckSound());
            RubberDuck rubberDuck = new RubberDuck(new RubberDuckSound());
            normalDuck.MakeSound();
            rubberDuck.MakeSound();
            normalDuck.Draw();
            rubberDuck.Draw();
        }
    }

    public interface Animal
    {
        public void MakeSound();
    }

    public abstract class Duck : Animal
    {
        public Sound Sound { get; set; }

        public Duck(Sound sound)
        {
            Sound = sound;
        }

        public void MakeSound()
        {
            Sound.MakeSound();
        }

        public abstract void Draw();
    }

    public class RubberDuck : Duck
    {
        public RubberDuck(Sound sound) : base(sound) {}

        public override void Draw()
        {
            Console.WriteLine("Drawing rubber duck");
        }
    }

    public class NormalDuck : Duck
    {
        public NormalDuck(Sound sound) : base(sound) {}
        
        public override void Draw()
        {
            Console.WriteLine("Drawing normal duck");
        }
    }

    public interface Sound
    {
        public void MakeSound();
    }

    public class DuckSound : Sound
    {
        public void MakeSound()
        {
            Console.WriteLine("Duck sound");
        }
    }
    
    public class RubberDuckSound : Sound
    {
        public void MakeSound()
        {
            Console.WriteLine("Rubber Duck sound");
        }
    }
}
