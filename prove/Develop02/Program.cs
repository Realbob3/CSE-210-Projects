
using System;
using System.IO;
public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine("-----------------------------------");
    }
}


public class Journal
{
    public List<Entry> entered_entries = new List<Entry>();

    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today that I want to remember?"
    };

    private const string SEPARATOR = "|~|";

    public void AddEntry(Entry newEntry)
    {
        entered_entries.Add(newEntry);
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n*** Journal Entries ***");
        foreach (Entry entry in entered_entries)
        {
            entry.Display();
        }
        Console.WriteLine("*** End of Journal ***\n");
    }

    public void SaveToFile(string filename)
    {
        try
        {
           
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in entered_entries)
                {
                    outputFile.WriteLine($"{entry._date}{SEPARATOR}{entry._promptText}{SEPARATOR}{entry._entryText}");
                }
            }
            Console.WriteLine($"\nJournal successfully saved to {filename}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);

            entered_entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { SEPARATOR }, StringSplitOptions.None);

                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._entryText = parts[2];

                    entered_entries.Add(newEntry);
                }
            }
            Console.WriteLine($"\nJournal successfully loaded from {filename}. Total entries: {entered_entries.Count}\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"\nError: The file '{filename}' was not found.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}\n");
        }
    }
}

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