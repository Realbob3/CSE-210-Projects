class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int numberChoice = 0;
        int numberChoice2 = 0;
        int numberChoice3 = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("What type of description would you like to see?");
            Console.WriteLine("1: Standard Details");
            Console.WriteLine("2: Full Details");
            Console.WriteLine("3: Short description");
            Console.Write("> ");
            choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
                while (numberChoice != 4)
                {
                    Console.Clear();
                    Console.WriteLine("What type of event would you like to see?");
                    Console.WriteLine("1: Lecture");
                    Console.WriteLine("2: Reception");
                    Console.WriteLine("3: Outdoor");
                    Console.Write("> ");
                    numberChoice = Convert.ToInt16(Console.ReadLine());
                    if (numberChoice == 1)
                    {
                        Lectures l = new Lectures("Coolguy", 1000);
                        l.Standard();
                        Console.ReadLine();
                    }
                    else if (numberChoice == 2)
                    {
                        Receptions r = new Receptions();
                        r.Standard();
                        Console.ReadLine();
                    }
                    else if (numberChoice == 3)
                    {
                        Outdoor o = new Outdoor("Rainy");
                        o.Standard();
                        Console.ReadLine();
                    }
                }
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("What type of event would you like to see?");
                Console.WriteLine("1: Lecture");
                Console.WriteLine("2: Reception");
                Console.WriteLine("3: Outdoor");
                Console.Write("> ");
                numberChoice2 = Convert.ToInt16(Console.ReadLine());
                    if (numberChoice2 == 1)
                    {
                        Lectures l = new Lectures("Coolguy", 1000);
                        l.Full();
                        Console.WriteLine("Speaker: Coolguy Capacity: 1000");
                        Console.ReadLine();

                    }
                    else if (numberChoice2 == 2)
                    {
                        Receptions r = new Receptions();
                        r.Full();
                        Console.WriteLine("Email: legoman@gmail.com");
                        Console.ReadLine();
                    }
                    else if (numberChoice2 == 3)
                    {
                        Outdoor o = new Outdoor("Rainy");
                        o.Full();
                        Console.WriteLine("Weather: Rainy");
                        Console.ReadLine();
                    }
            }
            else if (choice == 3)
            {
                Console.Clear();
                Console.WriteLine("What type of event would you like to see?");
                Console.WriteLine("1: Lecture");
                Console.WriteLine("2: Reception");
                Console.WriteLine("3: Outdoor");
                Console.Write("> ");
                numberChoice3 = Convert.ToInt16(Console.ReadLine());
                    if (numberChoice3 == 1)
                    {
                        Lectures l = new Lectures("Coolguy", 1000);
                        l.ShortDesc();
                        Console.ReadLine();

                    }
                    else if (numberChoice3 == 2)
                    {
                        Receptions r = new Receptions();
                        r.ShortDesc();
                        Console.ReadLine();
                    }
                    else if (numberChoice3 == 3)
                    {
                        Outdoor o = new Outdoor("Rainy");
                        o.ShortDesc();
                        Console.ReadLine();
                    }
            }
        }
    }
}