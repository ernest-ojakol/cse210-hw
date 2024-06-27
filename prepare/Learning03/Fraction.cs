public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){}

    public Fraction(int wholeNumber){
        this._top=wholeNumber;
        this._bottom=1;
    }

    public Fraction(int top, int bottom){
        this._top=top;
        this._bottom=bottom;
    }

    public int GetTop(){
        return _top;
    }

    public void SetTop(int top){
        this._top=top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void SetBottom(int bottom){
        this._bottom=bottom;
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return (double)_top/(double)_bottom;
    }
}