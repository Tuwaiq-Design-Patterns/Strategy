using System;

namespace FacadeDesignPattern
{
    class Program
    {
        interface IOS
        {
            public void DisplayWelcomeScreen();
        }
        interface IBios
        {
            public void Launch(IOS os);
            public void PowerOff();
        }

        class OS : IOS
        {
            public void DisplayWelcomeScreen()
            {
                Console.WriteLine("Welcome, system launched");
            }
        }

        class Bios : IBios
        {
            public void Launch(IOS os)
            {
                os.DisplayWelcomeScreen();
            }

            public void PowerOff()
            {
                Console.WriteLine("Power OFF");
            }
        }

        class Computer
        {
            private readonly IOS os;
            private readonly IBios bios;

            public Computer(IOS os, IBios bios)
            {
                this.os = os;
                this.bios = bios;
            }

            public void TurnON()
            {
                bios.Launch(this.os);
            }

            public void TurnOFF()
            {
                bios.PowerOff();
            }
        }



        static void Main(string[] args)
        {
            var myHPLaptop = new Computer(new OS(), new Bios());
            myHPLaptop.TurnON();
            myHPLaptop.TurnOFF();
        }
    }
}
