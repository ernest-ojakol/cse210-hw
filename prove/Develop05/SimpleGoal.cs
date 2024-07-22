public class SimpleGoal:Goal{
	protected bool _isComplete=false;
	
	public SimpleGoal(string name, string description, string points): base(name, description, points){
		_shortName=name;
		_description=description;
		_points=points;
	}

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal_{_shortName}_{_description}_{_points}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete=true;
    }
}