public class EternalGoal:Goal{
	
	public EternalGoal(string name, string description, string points): base(name, description, points){
		_shortName=name;
		_description=description;
		_points=points;
	}

    public override string GetStringRepresentation()
    {
        return $"EternalGoal_{_shortName}_{_description}_{_points}";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
    }
	
}