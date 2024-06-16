using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> user_numbers = new List<int>();
        
        int number = 10;
        while (number != 0)
        {
            Console.Write("Enter a number (0 to end): ");
            
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);
            user_numbers.Add(number);
        }

        int sum = 0;
        foreach (int num in user_numbers)
        {
            sum = sum + num;
        }

        Console.WriteLine($"Total: {sum}");

        float average = ((float)sum) / user_numbers.Count;
        Console.WriteLine($"Average: {average}");
        
        int maxNumber = user_numbers[0];
        for (int i = 1; i < user_numbers.Count; i++)
        {
            if (user_numbers[i] > maxNumber)
            {
                maxNumber = user_numbers[i];
            }
        }

        Console.WriteLine($"Max: {maxNumber}");
    }
}