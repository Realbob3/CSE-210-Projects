class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EXERCISE TRACKING");
        Console.WriteLine("__________________");
        Console.WriteLine();
        
        var runningActivity   = new RunningActivity("Running", "01 Jan 2023", 40, 5.0);
        var cyclingActivity   = new CyclingActivity("Cycling", "26 May 2022", 70, 9.5);
        var swimmingActivity  = new SwimmingActivity("Swimming", "15 Dec 2022", 35, 50);

        var activities = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        foreach (var activity in activities)
        {
            activity.DisplaySummary();
            Console.WriteLine();
            Console.WriteLine("___________________");
            Console.WriteLine();
        }
    }
}