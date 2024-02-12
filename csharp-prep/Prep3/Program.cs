using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int randomNumber = int.Parse(Console.ReadLine())
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int guess = -1;


        // We could also use a do-while loop here...
        while (guess != randomNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (randomNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}   
            
            //count = count += 1;
        //while (count < 15)
            //System.Console.WriteLine($"count = {count}");
            //count++;
        
        // do loops
       // int anotherCount = 0;
        //do 
        //{
           // System.Console.WriteLine($"AnotherCOunt = {anotherCount}");
        //}while (anotherCount < 10);

        // for loop
        //for(int i=0; i<5; i++){
            //System.Console.WriteLine($"i = {i}");

        
        //System.Console.WriteLine($"i = {i}");}