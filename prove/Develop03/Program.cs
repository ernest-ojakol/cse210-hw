using System;

class Program
{
    static void Main(string[] args)
    {
        //Added user input
        Console.WriteLine("We want to know your favorite Scripture and help you memorize it.\n");
        Console.WriteLine("In which Book is your favorite scripture?");
        string book=Console.ReadLine();
        Console.WriteLine("Chapter");
        string chapter=Console.ReadLine();
        Console.WriteLine("First Verse");
        string fVerse=Console.ReadLine();
        Console.WriteLine("Last Verse.(Enter '0' if there is only one verse)");
        string lVerse=Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"{book} {chapter} {fVerse} {lVerse}");
        Console.WriteLine("Enter the scripture text");
        string scriptureText=Console.ReadLine();
        Console.Clear();
        
        Reference reference=new Reference(book,int.Parse(chapter),int.Parse(fVerse),int.Parse(lVerse));
        Scripture scripture=new Scripture(reference,scriptureText);
        
        Console.Clear();

        string decision="";
        Random randomGenerator = new Random();
        
        while(decision!="quit"){
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            decision=Console.ReadLine();

            if(decision!="quit"){
                if(scripture.IsCompletelyHidden()){
                    decision="quit";
                }else{
                    int number = randomGenerator.Next(0, ((scriptureText.Split(" ").Length)));
                    //if it is already hidden, looks for one that's not hidden
                    while(scripture.GetWords().ElementAt(number).isHidden()){
                        number = randomGenerator.Next(0, ((scriptureText.Split(" ").Length)));
                    }
                    scripture.HideRandomWords(number);
                }
            }else{
                continue;
            }
        }

    }
}