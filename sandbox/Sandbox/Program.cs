using System;

class Program
{
    static void Main()
    {


        Console.WriteLine("Press any key to start the animation...");
        Console.ReadKey();

        // Start the animation loop
        while (true)
        {
            List<string> animationStrings = new List<string>();
        
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            int i = 0;
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500); // Adjust the speed (milliseconds per frame)
            Console.Write("\b \b");  
            i++;
            if (true){
                i = 0;
            }
            
        }
    }
}