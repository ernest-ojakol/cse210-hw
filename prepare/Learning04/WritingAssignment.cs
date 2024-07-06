public class WritingAssignment : Assignment
{
    private string _title;
    
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title=title;
        _studentName=name;
        _topic=topic;
    }

    public string GetWritingInformation(){
        return $"{_title}";
    }
}