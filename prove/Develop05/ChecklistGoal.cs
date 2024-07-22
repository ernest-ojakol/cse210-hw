public class ChecklistGoal:Goal{
	protected int _amountCompleted;
	protected int _target;
	protected int _bonus;
	
	public ChecklistGoal(string name, string description, string points, int target, int bonus): base(name, description, points){
		_shortName=name;
		_description=description;
		_points=points;
		_target=target;
		_bonus=bonus;
	}

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal_{_shortName}_{_description}_{_points}_{_target}_{_bonus}";
    }

    public override bool IsComplete()
    {
        if(_amountCompleted==_target){
            return true;
        }else{
            return false;
        }
    }

    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted+1;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }
}