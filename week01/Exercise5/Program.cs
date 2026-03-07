using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayOpenMessage();

        string userName = PromptUserName();
        int userNum = PromptUserNum();

        int squaredNum = SquareNum(userNum);

        DisplayResult(userName, squaredNum);
    }

    static void DisplayOpenMessage()
    {
        Console.WriteLine("Welcome to the program.");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNum()
    {
        Console.Write("What is your favorite number? ");
        string userNum = Console.ReadLine();
        return int.Parse(userNum);
    }

    static int SquareNum(int userNum)
    {
        return userNum * userNum;
    }

    static void DisplayResult(string userName, int squaredNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNum}.");
    }

}