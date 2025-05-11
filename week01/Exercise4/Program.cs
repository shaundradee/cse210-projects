using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int newNum;

        do
        {
            Console.Write("Enter number: ");
            string userInputNum = Console.ReadLine();
            newNum = int.Parse(userInputNum);

            if (newNum != 0)
            {
                numbers.Add(newNum);
            }

        } while (newNum != 0);  // Keep going until 0 is entered

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        float average = (float)sum / numbers.Count;
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");


    }
}