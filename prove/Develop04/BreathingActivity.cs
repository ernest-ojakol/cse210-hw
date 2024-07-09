public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name=name;
        _description=description;
        _duration=duration;
    }

    public void Run(){
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready");
        ShowSpinner(3);
        DateTime start=DateTime.Now;
        DateTime endTime=start.AddSeconds(_duration);
        
        while(DateTime.Now<endTime){
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.Write("\n");
            Console.Write("Breath out...");
            ShowCountDown(5);
            Console.Write("\n\n");
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }

}