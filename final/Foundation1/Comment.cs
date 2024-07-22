public class Comment{
    string _name;
    string _comment;

    public Comment(string name,string comment){
        _name=name;
        _comment=comment;
    }

    public string GetName(){
        return _name;
    }

    public string GetComment(){
        return _comment;
    }
}