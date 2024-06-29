public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        this._text=text;
    }
    
    public void Hide(){
        this._isHidden=true;
    }

    public bool isHidden(){
        return this._isHidden;
    }

    public string GetDisplayText(){
        return this._text;
    }
    
}