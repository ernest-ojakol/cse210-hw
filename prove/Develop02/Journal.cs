using System.IO;
public class Journal{
    
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach(Entry e in _entries){
            e.Display();
        }
    }

    public void SaveToFile(string file){
        foreach(Entry e in _entries){
            using (StreamWriter outputFile = new StreamWriter(file,true))
            {
            outputFile.WriteLine($"{e._date} {e._promptText} {e._entryText} {e._entryTextLengthComment}");
            }
        }
    }

    public void LoadFromFile(string file){
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine($"{line}");
        }
    }
}