public class Receptions : Event
{
    private bool _register;

    public Receptions() 
        : base("Lego City Reception,",
               "A man has fallen in the river, build the rescue chopper and celebrate with us.,",
               "April 29, 20XX,",
               "60 minutes,")
    {
        _event   = "Reception";
        _address = new Address("River St,", "Lego City,", "Lego Land,", "United States");
    }

    public void Register()
    {
        if (_register)
        {
            Console.WriteLine("You are registered for the event. Bring a chopper piece");
        }
        else
        {
            Console.WriteLine("No Chopper piece no sign up on time.");
        }
    }
}