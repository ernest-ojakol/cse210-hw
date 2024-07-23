public class LecturesEvent : Event
{
    private string _speaker;
    private string _capacity;

    public LecturesEvent(string title, string description, string date, string time, Address address, string speaker, string capacity): base(title, description, date, time, address){
        _title=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
        _speaker=speaker;
        _capacity=capacity;
    }

    public string GetFullDetails()
    {
        return $"LecturesEvent | {GetStandardDetails()} | {_speaker} | {_capacity}";
    }

    public string GetShortDescription()
    {
        return $"LecturesEvent | {_title} | {_date}";
    }

}