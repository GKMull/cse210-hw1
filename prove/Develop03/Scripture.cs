namespace Develop03;
using System;
class Program
{
    static void Main()
    {
        var memorizer = new ScriptureMemorizer();

        memorizer.AddScripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life");
        memorizer.AddScripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding in all your ways submit to him, and he will make your paths straight");
    }
}

