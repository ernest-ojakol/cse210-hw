public class OutdoorEvent : Event
{

    private string _weatherForecast;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weatherForecast): base(title, description, date, time, address){
        _title=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
        _weatherForecast=weatherForecast;
    }

    public string GetFullDetails()
    {
        return $"OutdoorEvent | {GetStandardDetails()} | {_weatherForecast}";
    }

    public string GetShortDescription()
    {
        return $"OutdoorEvent | {_title} | {_date}";
    }

}