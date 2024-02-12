using System.IO;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {   
        string filename = "MyFile.txt";
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        while()
        {
            Console.WriteLine("Journal Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string input = Console.ReadLine();
            int newInput = int.Parse(input);
            var entry = new List<Entry>();
            if (newInput == 1){

                string entry = Console.ReadLine();
                var text = new Entry();
                text.entrys = entry;
                entry.Add(text);

            }
            else if (newInput == 2){
                string isplay = Display();
                
            }
            else if(newInput == 3){

            }
            else if(newInput == 4){

            }
            else{

            }
        }
    }


    static string Display(){
        Console.Write();
        return 
    }
}

