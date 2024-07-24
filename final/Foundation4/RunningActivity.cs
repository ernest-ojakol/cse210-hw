public class RunningActivity : Activity
{
    protected int _distance;

    public RunningActivity(string date, int length, int distance):base(date,length){
        _date=date;
        _length=length;
        _distance=distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        double speed=GetSpeed();
        double pace=60/speed;
        return pace;
    }

    public override double GetSpeed()
    {
        double speed=_distance/(_length/60);
        return speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length}), Distance: {GetDistance().ToString("F2")}km, Speed {GetSpeed().ToString("F2")} kmph, Pace {GetPace().ToString("F2")} min per km";
    } 
}