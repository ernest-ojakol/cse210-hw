using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Grade Percentage : ");
        string percentage=Console.ReadLine();
        int grade=int.Parse(percentage);
        string letter="";

        if(grade>=90){
            letter="A";
            Console.WriteLine("You passed!");
        }else if(grade>=80 && grade<90){
            letter="B";
            Console.WriteLine("You passed!");
        }else if(grade>=70 && grade<80){
            letter="C";
            Console.WriteLine("You passed!");
        }else if(grade>=60 && grade<70){
            letter="D";
        }else if(grade<60){
            letter="F";
        }
        Console.WriteLine($"Your grade is: {letter}");
    }
}