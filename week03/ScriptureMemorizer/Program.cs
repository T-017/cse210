using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText(string.Empty));
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
        }
    }
}