using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != number)
        {
            Console.Write("Guess the magic number ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Go Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Go Lower");
            }
            else
            {
                Console.WriteLine("Thats it!");
            }

        }
    }
}