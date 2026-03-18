using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        List<Word> words = new List<Word>
        {
            new Word("For"),
            new Word("God"),
            new Word("so"),
            new Word("loved"),
            new Word("the"),
            new Word("world"),
            new Word("that"),
            new Word("he"),
            new Word("gave"),
            new Word("his"),
            new Word("one"),
            new Word("and"),
            new Word("only"),
            new Word("Son,"),
            new Word("that"),
            new Word("whoever"),
            new Word("believes"),
            new Word("in"),
            new Word("him"),
            new Word("shall"),
            new Word("not"),
            new Word("perish"),
            new Word("but"),
            new Word("have"),
            new Word("eternal"),
            new Word("life.")
        };

        Scripture scripture = new Scripture(reference.GetDisplayText(), words);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            scripture.HideRandomWords(3);
            Console.WriteLine("\nPress Enter to hide more words...");
            Console.ReadLine();
        }

        Console.WriteLine("\nCongratulations! You've memorized the scripture!");
    }
}