public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity) 
        : base("You too can backflip,",
               "Coolguy will demonstrate his cool backflipping skills,",
               "October 2, 20XX,",
               "3 Hours,")
    {
        _event   = "Lecture";
        _address = new Address("456 Dog St,", "Realplace,", "Utah,", "United States");
        _speaker = speaker;
        _capacity = capacity;
    }
}