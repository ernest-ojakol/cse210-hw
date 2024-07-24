public abstract class Activity{
    protected string _date;
    protected double _length;

    public Activity(string date, double length){
        _date=date;
        _length=length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetSummary();
}