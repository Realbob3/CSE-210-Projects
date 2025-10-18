
using System;
using System.IO;

public class Program
{


    public static void Main(string[] args)
    {
   
        Journal journal = new Journal();
        string choice = "";

        Console.WriteLine("Welcome to your journal! I guess?");

        while (choice != "5")
        {
        
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            Console.WriteLine(new string('-', 40));

            if (choice == "1")
            {
            
                string prompt = journal.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry saved.\n");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename to load? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename to save? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for journaling! Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.\n");
            }
        }
    }
}