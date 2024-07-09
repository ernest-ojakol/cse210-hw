using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Menu Options\n\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit\nSelect a choice from the menu.");
        string optionSelected=Console.ReadLine();
        
        while(optionSelected!="4"){
            if(optionSelected=="1"){
                Console.Clear();
                BreathingActivity breathingActivity=new BreathingActivity("Breathing Activity","Relax by breathing in and out",0);
                breathingActivity.Run();
            }else if(optionSelected=="2"){
                Console.Clear();
                ReflectingActivity reflectingActivity=new ReflectingActivity("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0);
                reflectingActivity.Run();
            }else if(optionSelected=="3"){
                Console.Clear();
                ListingActivity listingActivity=new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0);
                listingActivity.Run();
            }

            Console.Clear();
            Console.WriteLine("Menu Options\n\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit\nSelect a choice from the menu.");
            optionSelected=Console.ReadLine();
        }
    }
}