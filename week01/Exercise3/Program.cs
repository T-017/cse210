using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 10);

        int guess = -1;

        while (guess != answer)
        {
            Console.Write("Guess a number between 1 and 10: ");;
            guess = int.Parse(Console.ReadLine());

            if (guess < answer)
            {
                Console.Write("Higher, try again. ");
            }
            else if (guess > answer)
            {
                Console.Write("Lower, try again. ");
            }
            else
            {
                Console.WriteLine("That's correct.");
            }
        }
    }
}