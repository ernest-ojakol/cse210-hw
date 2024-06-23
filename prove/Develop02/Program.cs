using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator generator=new PromptGenerator();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = "";
        Journal journal=new Journal();
        Console.WriteLine("\nWelcome to the Journal Program\nPlease select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?\n");
        string response=Console.ReadLine();
        int response_=int.Parse(response);

        while(response_ != 5){
            if(response_ ==1){
                Entry entry=new Entry();
                string prompt=generator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string promptResponse=Console.ReadLine();
                dateText=theCurrentTime.ToShortDateString();
                entry._date=dateText;
                entry._entryText=promptResponse;
                //Exceeding requirements by adding a comment on the entry text length. Journals usually need more detail
                if(promptResponse.Length>20){
                    entry._entryTextLengthComment="Adequate detail provided.";
                }else{
                    entry._entryTextLengthComment="Short Response. More detail might be needed.";
                }
                entry._promptText=prompt;
                journal._entries.Add(entry);
            }else if(response_ ==2){
                journal.DisplayAll();
            }else if(response_ ==3){
                Console.WriteLine("\nPlease Enter the name of the file\n");
                string fileName=Console.ReadLine();
                journal.LoadFromFile(fileName);
            }else if(response_ ==4){
                Console.WriteLine("\nPlease Enter the name of the file\n");
                string fileName=Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("\nSaved Successfully\n");
            }else{
                Console.WriteLine("Unknown Response");
            }
            Console.WriteLine("\nPlease select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?\n");
            response=Console.ReadLine();
            response_=int.Parse(response);
        }

    }
}