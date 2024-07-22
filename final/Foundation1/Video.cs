public class Video{
    string _title;
    string _author;

    int _length;

    List<Comment> _comments=new List<Comment>();

    public Video(string title,string author,int length){
        _title=title;
        _author=author;
        _length=length;
    }

    public List<Comment> GetComments(){
        return _comments;
    }

    public string GetTitle(){
        return _title;
    }

    public string GetAuthor(){
        return _author;
    }

    public int GetLength(){
        return _length;
    }

    public int GetCommentNumber(){
        return _comments.Count();
    }

}