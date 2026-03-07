using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 2;

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Lesser");
        }
        else
        {
            Console.WriteLine("Equal");
        }
    }
}