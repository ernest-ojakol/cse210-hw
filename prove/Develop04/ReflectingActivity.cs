public class ReflectingActivity : Activity
{
    private List<string> _questions=new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    private List<string> _prompts=new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
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
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.WriteLine("You many begin in");
        ShowCountDown(5);
        DateTime start=DateTime.Now;
        DateTime endTime=start.AddSeconds(_duration);
        
        while(DateTime.Now<endTime){
            DisplayQuestions();
            ShowSpinner(5);
        }
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public string GetRandomPrompt(){
        Random random = new Random();
        int randomNumber = random.Next(0,(_prompts.Count-1));

        return _prompts[randomNumber]; 
    }

    public string GetRandomQuestion(){
        Random random = new Random();
        int randomNumber = random.Next(0,(_questions.Count-1));

        return _questions[randomNumber]; 
    }

    public void DisplayPrompt(){
        String prompt=GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }

    public void DisplayQuestions(){
        String question=GetRandomQuestion();
        Console.WriteLine($">{question}");
    }

}