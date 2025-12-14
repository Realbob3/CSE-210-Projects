public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather) 
        : base("Sunfish Petting Zoo,",
               "Don't ask us how we got it here.,",
               "December 29th, 20XX,",
               "45 minutes,")
    {
        _event   = "Outdoor Event";
        _address = new Address("NoPool St,", "Realplace,", "Utah,", "United States");
        _weather = weather;
    }
}