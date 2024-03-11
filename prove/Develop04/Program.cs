using System;
using System.Reflection;


namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness Activities App!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Listing activity");
            Console.WriteLine("3. Start Reflection activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");

            int choice = GetValidChoice();

            MindfulnessActivity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    return;
            }

            activity.Start();
        }

        static int GetValidChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Enter 1, 2, or 3:");
            }
            return choice;
        }
    }

    class MindfulnessActivity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public virtual void Start()
        {
            Console.WriteLine($"Starting {Name} activity...");
            Console.WriteLine(Description);
            Console.Write("How long, in seconds, would you like for your session? ");
            int Duration = Convert.ToInt32(Console.ReadLine());
            
            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
        }
    }

    class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity()
        {
            Name = "Breathing Activity";
            Description = "Helps you pace your breathing for relaxation.";
        }

        public override void Start()
        {
            base.Start();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(Duration);

            while (DateTime.Now < endTime){
                Console.WriteLine("Breathe in...");
                for (int i = 5; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("exhale...");
                for (int i = 5; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

            }
            
            // Implement deep breathing guidance (countdown or animation)
            Console.WriteLine("Well Done");
            return;
        }
    }

    class ReflectionActivity : MindfulnessActivity
    {
        public ReflectionActivity()
        {
            Name = "Reflection Activity";
            Description = "Think about a successful experience.";
        }

        public override void Start()
        {
            base.Start();
            // Prompt user with reflection questions
            Console.WriteLine("What happened during that experience?");
            // Add more reflection prompts here
        }
    }

    class ListingActivity : MindfulnessActivity
    {
        public ListingActivity()
        {
            Name = "Listing Activity";
            Description = "List positive aspects or strengths.";
        }

        public override void Start()
        {
            base.Start();
            // Prompt user to list related things
            Console.WriteLine("List as many positive aspects as you can.");
            // Add more specific prompts here
        }
    }
}
