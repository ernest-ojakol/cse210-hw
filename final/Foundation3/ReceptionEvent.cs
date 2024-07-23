public class ReceptionEvent : Event
{

    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string rsvpEmail): base(title, description, date, time, address){
        _title=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
        _rsvpEmail=rsvpEmail;
    }

    public string GetFullDetails()
    {
        return $"ReceptionEvent | {GetStandardDetails()} | {_rsvpEmail}";
    }

    public string GetShortDescription()
    {
        return $"ReceptionEvent | {_title} | {_date}";
    }

}