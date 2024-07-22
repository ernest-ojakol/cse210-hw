using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1=new Video("Jinja Tour","Rita Kyomugisha",120);
        Video video2=new Video("Kampala Tour","Akol Patrick",100);
        Video video3=new Video("Duabi Tour","Michael Mawejje",1200);
        video1.GetComments().Add(new Comment("Atta Mamito","Great Video"));
        video1.GetComments().Add(new Comment("Liz K","Great Video"));
        video1.GetComments().Add(new Comment("Emma K","Great Video"));
        video2.GetComments().Add(new Comment("Atta Mamito","Great Video"));
        video2.GetComments().Add(new Comment("Liz K","Great Video"));
        video2.GetComments().Add(new Comment("Emma K","Great Video"));
        video3.GetComments().Add(new Comment("Atta Mamito","Great Video"));
        video3.GetComments().Add(new Comment("Liz K","Great Video"));
        video3.GetComments().Add(new Comment("Emma K","Great Video"));

        List<Video> videos=new List<Video>{video1,video2,video3};

        foreach(Video video in videos){
            Console.WriteLine($"Author: {video.GetAuthor()} | Title: {video.GetTitle()} | Length: {video.GetLength()} Seconds");
            Console.WriteLine($"Comments:{video.GetCommentNumber()}");
            foreach(Comment comment in video.GetComments()){
                Console.WriteLine($"\tName:{comment.GetName()} | Comment:{comment.GetComment()}");
            }
        }


    }
}