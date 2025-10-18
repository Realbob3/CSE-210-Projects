using System;
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