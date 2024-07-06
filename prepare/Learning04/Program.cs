using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment=new Assignment("Terry Wilfred","Gibberish");

        Console.WriteLine($"{assignment.GetSummary()}");

        MathAssignment mathAssignment=new MathAssignment("Terry Wise","Gibberish","2","1-4");
        Console.WriteLine($"{mathAssignment.GetSummary()}");
        Console.WriteLine($"{mathAssignment.GetHomeworkList()}");

        WritingAssignment writingAssignment=new WritingAssignment("Terry Wise","Gibberish","A Long Walk to Freedom By Nelson Mandela");
        Console.WriteLine($"{writingAssignment.GetSummary()}");
        Console.WriteLine($"{writingAssignment.GetWritingInformation()}");
    }
}