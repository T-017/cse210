using System;

class Program
{
    static void Main(string[] args)
    {     
        List<int> numbersList = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a list of numbers, enter 0 to quit: ");

            string numberEntry = Console.ReadLine();
            number = int.Parse(numberEntry);

            if (number != 0)
            {
                numbersList.Add(number);
            }
        }
        int sum = 0;
        foreach (int num in numbersList)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = (float)sum / numbersList.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        int max = numbersList[0];
        foreach (int num in numbersList)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");
    }
}