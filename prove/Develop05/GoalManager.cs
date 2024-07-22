using System.IO;
public class GoalManager{
    protected List<Goal> _goals=new List<Goal>();
    protected int _score;

    public GoalManager(){}

    public void Start(){
        DisplayPlayerInfo();
        Console.WriteLine($"Menu Options\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\nSelect a choice from the menu.");
        string optionSelected=Console.ReadLine();
        
        while(optionSelected!="6"){
            if(optionSelected=="1"){
                CreateGoal();
            }else if(optionSelected=="2"){
                ListGoalDetails();
            }else if(optionSelected=="5"){
                RecordEvent();
            }else if(optionSelected=="3"){
                SaveGoals();
            }else if(optionSelected=="4"){
                LoadGoals();
            }

            DisplayPlayerInfo();
            Console.WriteLine("Menu Options\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\nSelect a choice from the menu.");
            optionSelected=Console.ReadLine();
        }
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames(){
        Console.WriteLine("The types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\nWhat type of goal would you like to set?");
    }

    public void ListGoalDetails(){
        int counter=1;
        foreach(Goal goal in _goals){
            string []classs=goal.GetStringRepresentation().Split("_");
            if(!classs[0].StartsWith("ChecklistGoal")){
                if(goal.IsComplete()){
                    Console.WriteLine($"{counter}. [X] {goal.GetDetailsString()}");
                }else{
                    Console.WriteLine($"{counter}. [ ] {goal.GetDetailsString()}");
                }
            }else{
                ChecklistGoal clGoal= (ChecklistGoal)goal;
                if(goal.IsComplete()){
                    Console.WriteLine($"{counter}. [X] {goal.GetDetailsString()} -- Currently Completed {clGoal.GetAmountCompleted()}/{clGoal.GetTarget()}");
                }else{
                    Console.WriteLine($"{counter}. [ ] {goal.GetDetailsString()} -- Currently Completed {clGoal.GetAmountCompleted()}/{clGoal.GetTarget()}");
                }
            }
            counter++;
        }
    }

    public void CreateGoal(){
        Console.WriteLine("The types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\nWhat type of goal would you like to set?");
        string goalChoice=Console.ReadLine();
        if(goalChoice=="1"){
            Console.Write("What is the name of the goal?");
            string goalName=Console.ReadLine();
            Console.Write("What is the short description of the goal?");
            string goalDescription=Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?");
            string goalPoints=Console.ReadLine();
            Goal goal=new SimpleGoal(goalName,goalDescription,goalPoints);
            _goals.Add(goal);
        } else if(goalChoice=="2"){
            Console.Write("What is the name of the goal?");
            string goalName=Console.ReadLine();
            Console.Write("What is the short description of the goal?");
            string goalDescription=Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?");
            string goalPoints=Console.ReadLine();
            Goal goal=new EternalGoal(goalName,goalDescription,goalPoints);
            _goals.Add(goal);
        }else{
            Console.Write("What is the name of the goal?");
            string goalName=Console.ReadLine();
            Console.Write("What is the short description of the goal?");
            string goalDescription=Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?");
            string goalPoints=Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus?");
            string goalBonusTimes=Console.ReadLine();
            Console.Write("Bonus for accomplishing the goal?");
            string goalBonus=Console.ReadLine();
            Goal goal=new ChecklistGoal(goalName,goalDescription,goalPoints,int.Parse(goalBonusTimes),int.Parse(goalBonus));
            _goals.Add(goal);
        }

    }

    public void RecordEvent(){
        int counter=1;
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals){
            Console.WriteLine($"{counter}. {goal.GetShortName()}");
            counter++;
        }
        Console.Write("Which goal did you accomplish?");
        string choice=Console.ReadLine();
        int choose=int.Parse(choice);
        for(int i=0;i<_goals.Count;i++){
           if(i==(choose-1)){
                string []classs=_goals.ElementAt(i).GetStringRepresentation().Split("_");
                _goals.ElementAt(i).RecordEvent();
                if(!classs[0].StartsWith("ChecklistGoal")){
                    _score=_score+int.Parse(_goals.ElementAt(i).GetPoints());
                    Console.WriteLine($"Congrats, you earned {_goals.ElementAt(i).GetPoints()} points.");
                }else{
                    ChecklistGoal clGoal= (ChecklistGoal)_goals.ElementAt(i);
                    int scorePoints=0;
                    if(clGoal.IsComplete()){
                        _score=_score+int.Parse(_goals.ElementAt(i).GetPoints())+clGoal.GetBonus();
                        scorePoints=int.Parse(_goals.ElementAt(i).GetPoints())+clGoal.GetBonus();
                    }else{
                        _score=_score+int.Parse(_goals.ElementAt(i).GetPoints());
                        scorePoints=int.Parse(_goals.ElementAt(i).GetPoints())+clGoal.GetBonus();
                    }
                    Console.WriteLine($"Congrats, you earned {scorePoints} points.");
                }
                
                Console.WriteLine($"You now have {_score} points.");
           } 
        }
        
    }

    public void SaveGoals(){
        Console.Write("Which is the name of the goal file?");
        string fileName=Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            outputFile.WriteLine($"{_score}");
            foreach(Goal goal in _goals){
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
        Console.WriteLine("File created and saved.");
    }

    public void LoadGoals(){
        Console.Write("Which is the name of the goal file?");
        string fileName=Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score=int.Parse(lines[0]);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("_");
            if(parts.Count()==0){
                continue;
            }else{
                if(parts[0].Equals("SimpleGoal")){
                    Goal goal=new SimpleGoal(parts[1],parts[2],parts[3]);
                    _goals.Add(goal);
                }else if(parts[0].Equals("EternalGoal")){
                    Goal goal=new EternalGoal(parts[1],parts[2],parts[3]);
                    _goals.Add(goal);
                }else if(parts[0].Equals("ChecklistGoal")){
                    Goal goal=new ChecklistGoal(parts[1],parts[2],parts[3],int.Parse(parts[4]),int.Parse(parts[5]));
                    _goals.Add(goal);
                }
            }
        }

    }

    public List<Goal> GetGoals(){
        return _goals;
    }
}