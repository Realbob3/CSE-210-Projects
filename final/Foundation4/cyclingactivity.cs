
public class CyclingActivity : Activity
{
    private double _speed;

    public override double GetSpeed()
    {
        return _speed;
    }

    public CyclingActivity(string activityName, string date, double lengthInMinutes, double speed) 
        : base(activityName, date, lengthInMinutes)
    {
        _speed = speed;
    }
}