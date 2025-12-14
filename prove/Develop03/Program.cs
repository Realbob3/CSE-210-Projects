using System;

namespace Develop03
{
    class Program
    {
        /*
        * Exceeding Requirements:
        * 1. The HideRandomWords method implements the STRETCH CHALLENGE:
        * It only selects words that are NOT already hidden, ensuring efficiency
        * and a smooth progression to full memorization.
        * 2. The code demonstrates proper use of LINQ (.Where(), .All()) for concise
        * data manipulation in the Scripture class.
        */
        static void Main(string[] args)
        {
            ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
            string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            
            Scripture scripture = new Scripture(reference, text);

            string userInput = "";

            while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                Console.WriteLine("Press Enter to continue, or type 'quit' to finish:");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }
                else 
                {
                    scripture.HideRandomWords(3);
                }
            }
            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nProgram finished. Good job on your memorization!");
        }
    }
}