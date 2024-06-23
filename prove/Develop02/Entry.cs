public class Entry{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryTextLengthComment;

    public void Display(){
        Console.WriteLine($"{_date} {_promptText} {_entryText} {_entryTextLengthComment}");
    }
}