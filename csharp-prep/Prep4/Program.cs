using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputnumber = -1;
        while (inputnumber != 0)
        {
            Console.Write("Please enter a number, type 0 to quit");

            string inputresponse = Console.ReadLine();
            inputnumber = int.Parse(inputresponse);
            if (inputnumber != 0)
            {
                numbers.Add(inputnumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");
    }
}