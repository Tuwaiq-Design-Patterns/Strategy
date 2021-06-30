using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Examination_Strategy
{
        class Program {   
                static void Main(string[] args)
                {
 
                    GymContext aGym = new GymContext();

                    Trainee Trainee1 = new Trainee();
                    Trainee1.Name = "Batool";
                    Trainee1.Age = "Child";

                    Trainee Trainee2 = new Trainee();
                    Trainee2.Name = "Raneen";
                    Trainee2.Age = "Senior";

                    Trainee Trainee3 = new Trainee();
                    Trainee3.Name = "Sameera";
                    Trainee3.Age = "Teenager";

                    aGym.trainees.Add(Trainee1);
                    aGym.trainees.Add(Trainee2);
                    aGym.trainees.Add(Trainee3);


                    Console.WriteLine("Please enter the visit's Date (DD)");
                    string date = Console.ReadLine();
                    switch (date)
                    {
                        case "15":
                            aGym.Trainer_on_Duty = new ResistanceTrainer();
                            break;
                        case "28":
                            aGym.Trainer_on_Duty = new CardioTrainer();
                            break;
                        default:
                            Console.WriteLine("No trainers available today, please select another date");
                            Environment.Exit(0);
                    break;
                    }

                    foreach (Trainee oneTrainee in aGym.trainees)
                    {
                        aGym.Trainer_on_Duty.aTrainee = oneTrainee;
                        Console.WriteLine();
                        aGym.StartTrainerActivies();
                    }

                    Console.ReadLine();
                }
            }

    public class Trainee
    {
        public string Name { get; set; }
        public string Age { get; set; }

    }

    //Strategy
    abstract public class Trainer
    {
        public Trainee aTrainee { get; set; }
        abstract public void ExamineTrainee();
        abstract public void GenerateBill();
        abstract public void CreateReport();
        abstract public void ConductCardio();
    }

    //Context
    public class GymContext
    {
        public List<Trainee> trainees = new List<Trainee>();
        public Trainer Trainer_on_Duty { get; set; }

        public void StartTrainerActivies()
        {
            Trainer_on_Duty.ExamineTrainee();
            Trainer_on_Duty.ConductCardio();
            Trainer_on_Duty.GenerateBill();
            Trainer_on_Duty.CreateReport();
        }
    }

    //StrategyA
    public class ResistanceTrainer : Trainer
    {
        const int sessionFee = 80;

        public override void ExamineTrainee()
        {

            Console.WriteLine("Resistance trainer starts body examination for " + aTrainee.Name + "....");

            Console.WriteLine("Muscle examination in process...");

            Console.WriteLine("Body mass examination in process...");

            Console.WriteLine("Exam completed for " + aTrainee.Name);

        }

        public override void ConductCardio()
        {
            Console.WriteLine("Cardio session in process, 2 sets of jumping jacks and burpees");

        }

        public override void GenerateBill()
        {
            Console.WriteLine("Generating the billing info...");
            Console.WriteLine("Session Fee : $" + sessionFee);

            switch (aTrainee.Age)
            {
                case "Senior":
                    Console.WriteLine("Extra 35%  discount is applied for " + aTrainee.Name);

                    Console.WriteLine("Total due: " + sessionFee * (1 - 0.35));
                    break;
                case "Child":
                    Console.WriteLine("Extra 15% discount for " + aTrainee.Name);
                    Console.WriteLine("Total due: " + sessionFee * (1 - 0.15));
                    break;
                default:
                    Console.WriteLine("Extra 5% discount for " + aTrainee.Name);
                    Console.WriteLine("Total due: " + sessionFee * (1 - 0.05));
                    break;
            }
        }

        public override void CreateReport()
        {
            Console.WriteLine("Report generated, visit again...");
        }
    }

    //StrategyB
    public class CardioTrainer : Trainer
    {
        const int sessionFee = 180;

        public override void ExamineTrainee()
        {

            Console.WriteLine("Fat mass examination for " + aTrainee.Name + "....");

            Console.WriteLine("Body mass measurement in process...");

            Console.WriteLine("Exam completed for" + aTrainee.Name);
        }

        public override void ConductCardio()
        {
            Console.WriteLine("Muscle building session in process, 2 sets of intense resistanse excercises");

        }

        public override void GenerateBill()
        {
            Console.WriteLine("Generating the billing info...");
            Console.WriteLine("Examination Fee : $" + sessionFee);

            switch (aTrainee.Age)
            {
                case "Senior":
                    Console.WriteLine("Extra 35% discount is applied for " + aTrainee.Name);
                    Console.WriteLine("Total due: " + sessionFee * (1 - 0.35));
                    break;

                    default:
                    Console.WriteLine("Extra 5% discount for " + aTrainee.Name);
                    Console.WriteLine("Total due: " + sessionFee * (1 - 0.05));
                    break;
            }

        }

        public override void CreateReport()
        {
            Console.WriteLine("Report generated, visit again...");
            Console.WriteLine("We  recommend " + aTrainee.Name +" to join our weekly practice session every Friday.");

        }
    }

}
  