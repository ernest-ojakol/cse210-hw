public abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name,string description,string points){
        _shortName=name;
        _description=description;
        _points=points;
    }

    public abstract void RecordEvent();
	
	public abstract bool IsComplete();

    public string GetDetailsString(){
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public string GetPoints(){
        return _points;
    }

    public string GetShortName(){
        return _shortName;
    }

    public string GetDescription(){
        return _description;
    }
}