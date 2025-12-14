
public class Activity
{
    private string _activityName;
    private string _date;
    private double _lengthInMinutes;

    public virtual double GetDistance()
    {
        return GetSpeed() * _lengthInMinutes;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _lengthInMinutes) * 60;
    }

    protected virtual double GetPace()
    {
        return 60 / GetSpeed();
    }

    public void DisplaySummary()
    {
        Console.WriteLine(
            $"{_date} {_activityName} ({_lengthInMinutes} min) - " +
            $"Distance: {GetDistance()} miles, " +
            $"Speed: {GetSpeed():0.#} mph, " +
            $"Pace: {GetPace():0.#} min per mile"
        );
    }
    public Activity(string activityName, string date, double lengthInMinutes)
    {
        _activityName   = activityName;
        _date           = date;
        _lengthInMinutes = lengthInMinutes;
    }
}