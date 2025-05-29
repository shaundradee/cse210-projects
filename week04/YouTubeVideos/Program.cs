using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video vid1 = new Video("Hip Hop Help", "Bobby Bones", 4932);
        vid1.AddComment(new Comment("Jill", "Really loved this!"));
        vid1.AddComment(new Comment("Jane", "Helped me be motivated to move!"));
        vid1.AddComment(new Comment("Bill", "Now I can confidently dance with my girlfriend!"));
        vid1.AddComment(new Comment("Tiffany", "Easy to follow along."));

        videos.Add(vid1);

        Video vid2 = new Video("How to braid hair", "Suzy Cue", 9012);
        vid2.AddComment(new Comment("Tabitha", "Helped me learn so I could do my daughter's hair."));
        vid2.AddComment(new Comment("Tracy", "Love this!"));
        vid2.AddComment(new Comment("Chad", "Easy to follow along. My daughter is proud of me!"));

        videos.Add(vid2);

        Video vid3 = new Video("How to Paint Daisies", 78977);
        vid3.AddComment(new Comment("Beth", "Made for a perfect girls' night activity!"));
        vid3.AddComment(new Comment("Jason", "Did this as a date night with my girlfriend."));
        vid3.AddComment(new Comment("Lynn", "Loved it!"));
        vid3.AddComment(new Comment("Nataly", "Learned a lot and have a great painting to hang in my room!"));

        videos.Add(vid3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("\n--------------------------");
        }

    }
}