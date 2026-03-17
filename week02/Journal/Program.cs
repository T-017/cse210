using System;

// An additional if statement to the LoadFromFile method of the Journal class that will write out "File not found: " if the file entered cannot be located to load, which exceeds the requirements.

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGen promptGen = new PromptGen();
        string userInput = "";

        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please select which prompt you would like: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                string entryText = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                newEntry._promptText = prompt;
                newEntry._entryText = entryText;
                journal.AddEntry(newEntry);
            }
            else if (userInput == "2")
            {
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Enter the filename to load from:");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Enter the filename to save to:");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }

    }
}