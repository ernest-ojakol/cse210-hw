using System;

class Program
{
    static void Main(string[] args)
    {
        Activity runningActivity=new RunningActivity("24/July/2024",30,6);
        Activity cyclingActivity=new BicycleActivity("24/July/2024",50,30);
        Activity swimmingActivity=new SwimmingActivity("24/July/2024",30,50);
        List<Activity> activities=new List<Activity>{runningActivity,cyclingActivity,swimmingActivity};

        foreach(Activity activity in activities){
            Console.WriteLine($"{activity.GetSummary()}");
        }
    }
}