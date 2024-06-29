public class Scripture{
    private Reference _reference;
    private List<Word> _words=new List<Word>();

    public Scripture(Reference reference,string text){
        this._reference=reference;
        string[] splitText = text.Split(' ');

        foreach (string textt in splitText) {
            Word word=new Word(textt);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide){
        _words.ElementAt(numberToHide).Hide();
    }

    public String GetDisplayText(){
        string reference=_reference.GetDisplayText();
        string scriptureText="";

        foreach(Word word in _words){
            if(word.isHidden()){
                string replacement="";
                for(int i=0;i<word.GetDisplayText().Count();i++){
                    replacement=replacement+"_";
                }
                scriptureText= $"{scriptureText} {replacement}";
            }else{
                scriptureText=scriptureText+$" {word.GetDisplayText()}";
            }

        }

        return $"{reference} {scriptureText}";
    }

    public bool IsCompletelyHidden(){
        bool allHidden = _words.All(word => word.isHidden() == true);
        return allHidden;
    }

    public List<Word> GetWords(){
        return _words;
    }
}