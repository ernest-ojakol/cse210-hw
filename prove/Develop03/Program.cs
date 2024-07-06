using System;

class Program
{
    static void Main(string[] args)
    {
        string book="John";
        int chapter=3;
        int fVerse=16;
        int lVerse=0;

        string scriptureText="For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        Reference reference=new Reference(book,chapter,fVerse,lVerse);
        Scripture scripture=new Scripture(reference,scriptureText);
        
        Console.Clear();

        string decision="";
        Random randomGenerator = new Random();
        
        while(decision!="quit"){
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText()+"\n");
            
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