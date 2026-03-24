using System;

// Went beyond the requirements of the assignment by adding input validation to ensure the user only enters "quit" or presses enter to continue.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        bool start = true;
        while (start)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            scripture.HideRandomWords(3);
            Console.WriteLine("Press enter to continue or type quit to exit.");
            string input = Console.ReadLine();
            while (input.ToLower() != "quit" && input != "")
            {
                Console.WriteLine("Invalid input. Press enter to continue or type quit to exit.");
                input = Console.ReadLine();
            }
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("You have memorized the scripture.");
                break;
            }
        }
    }
}