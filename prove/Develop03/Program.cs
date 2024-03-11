using System;

class Develop03
{
    private Dictionary<string, string> scripture = new Dictionary<string, string>();

    public void AddScripture(string reference, string text)
    {
        scripture[reference] = text;
    }

    public void MemorizeScripture(string reference)
    {
        if (scriptures.TryGetValue(reference, out var scriptureText))
        {
            Console.Clear();
            Console.WriteLine($"Scripture: {reference}");
            Console.WriteLine(scriptureText);

            Console.WriteLine("\nPress Enter to reveal more words or type 'quit' to exit.");
            while (true)
            {
                var input = Console.ReadLine().Trim().ToLower();
                if (input == "quit")
                    break;

                // Hide a few random words (you can customize this logic)
                var hiddenText = HideRandomWords(scriptureText);
                Console.Clear();
                Console.WriteLine($"Scripture: {reference}");
                Console.WriteLine(hiddenText);
            }
        }
        else
        {
            Console.WriteLine($"Scripture '{reference}' not found.");
        }
    }

    private string HideRandomWords(string text)
    {
        // Replace this with your logic to hide words (e.g., remove every nth word)
        // For simplicity, let's hide every second word.
        var words = text.Split(' ');
        for (int i = 1; i < words.Length; i += )
        {
            words[i] = new string('*', words[i].Length);
        }
        return string.Join(" ", words);
    }
}

