public class SwimmingActivity : Activity
{
    protected int _laps;

    public SwimmingActivity(string date, int length, int laps):base(date,length){
        _date=date;
        _length=length;
        _laps=laps;
    }

    public override double GetDistance()
    {
        int distance=(_laps*50)/1000;
        return distance;
    }

    public override double GetPace()
    {
        double pace=GetDistance()/_length;
        return pace;
    }

    public override double GetSpeed()
    {
        double dist=GetDistance();
        double speed=dist/(_length/60);
        return speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length}), Distance: {GetDistance().ToString("F2")}km, Speed {GetSpeed().ToString("F2")} kmph, Pace {GetPace().ToString("F2")} min per km";
    }
}