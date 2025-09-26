using System;

class Program
{
    static void Main(string[] args)
    {
        welcomemessage();

        string name = Promptname();
        int favnumber = Promptfavnumber();

        int squarednumber = squarenumber(favnumber);
        
        int birthyear;
        Promptuserbirthyear(out birthyear);

        

        displayresult(name, squarednumber, birthyear);
    }

    static void welcomemessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Promptname()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int Promptfavnumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favnumber = int.Parse(Console.ReadLine());
        return favnumber;
    }
    static void Promptuserbirthyear(out int birthyear)
    {
        Console.Write("please enter the year you were born: ");
        birthyear = int.Parse(Console.ReadLine());
    }
    static int squarenumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void displayresult(string name, int square, int birthyear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthyear} years old this year.");
    }
}