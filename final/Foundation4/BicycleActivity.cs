public class BicycleActivity : Activity
{
    protected int _speed;

    public BicycleActivity(string date, int length, int speed):base(date,length){
        _date=date;
        _length=length;
        _speed=speed;
    }

    public override double GetDistance()
    {
        double distance=_speed*(_length/60);
        return distance;
    }

    public override double GetPace()
    {
        double speed=GetSpeed();
        double pace=GetDistance()/_length;
        return pace;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length}), Distance: {GetDistance().ToString("F2")}km, Speed {GetSpeed().ToString("F2")} kmph, Pace {GetPace().ToString("F2")} min per km";
    }
}