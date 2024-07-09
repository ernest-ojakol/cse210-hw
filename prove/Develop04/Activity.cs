public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name,string description,int duration){
        _name=name;
        _description=description;
        _duration=duration;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration=Console.ReadLine();
        _duration=int.Parse(duration);
    }

    public void DisplayEndingMessage(){
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds){
        List<string> animationStrings=new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");

        DateTime startTime=DateTime.Now;
        DateTime endTime=startTime.AddSeconds(seconds);
        int count=0;
        while(DateTime.Now<endTime){
            Console.Write(animationStrings[count]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            count++;
            if(count>=animationStrings.Count){
                count=0;
            }
        }
    }

    public void ShowCountDown(int seconds){
        for(int i=seconds;i>0;i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}