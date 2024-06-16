using System;

class Program
{
    static void Main(string[] args)
    {
        //Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1, 200);
        Console.WriteLine("What is the magic number?");
        string magic=Console.ReadLine();
        int number=int.Parse(magic);

        Console.WriteLine("What is your guess?");
        string guess=Console.ReadLine();
        int guessed_number=int.Parse(guess);
        int guesses=0;

        while(guessed_number!=number){
            if(guessed_number>number){
                Console.WriteLine("Higher");
            }else{
                Console.WriteLine("Lower");
            }
            Console.WriteLine("Please guess a number between 1 and 200");
            guess=Console.ReadLine();
            guessed_number=int.Parse(guess);
            guesses++;
        }
        Console.WriteLine($"My number was {number}\nYour guess was {guessed_number}\nYou made {guesses} guesses");
    }
}