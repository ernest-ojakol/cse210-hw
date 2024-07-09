public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts=new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
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
        Console.WriteLine("List as many responses as you can for the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You many begin in");
        ShowCountDown(5);
        DateTime start=DateTime.Now;
        DateTime endTime=start.AddSeconds(_duration);
        List<string> responses = GetListFromUser();
        while(DateTime.Now<endTime){
            Console.Write(">");
            string response=Console.ReadLine();
            responses.Add(response);
        }
        _count=responses.Count;
        Console.WriteLine($"You listed {_count} items!");

        Console.WriteLine("\nWell Done!");
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public string GetRandomPrompt(){
        Random random = new Random();
        int randomNumber = random.Next(0,(_prompts.Count-1));

        return _prompts[randomNumber]; 
    }

    public List<string> GetListFromUser(){
        return new List<string>();
    }

}