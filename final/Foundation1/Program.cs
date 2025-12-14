class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Doing 1 backflip", "Coolguy", 5);
        video1.AddComment("Jeremy", "This backflip changed my life");
        video1.AddComment("Little Timmy", "Bet I could do 2 backflips");
        video1.AddComment("Timothy", "I miss your old content");
        
        Video video2 = new Video("First video!", "Jeffery da kidd", 85000);
        video2.AddComment("Harold", "Get off the platform kid");
        video2.AddComment("James", "First video is always rough but keep going!");
        video2.AddComment("Coolguy", "Legend");

        Video video3 = new Video("Prank gone wrong 3am hassel", "Master Prankerster", 600);
        video3.AddComment("Susie", "I think i'm scared of clowns now");
        video3.AddComment("Luke", "Shouldn't of ran from the cops");
        video3.AddComment("Coolguy", "Keep pranking brother");

        Video video4 = new Video("Why are sunfish the way they are?", "Sunfish Hater", 340);
        video4.AddComment("Sunfish questioner", "I agree why are they like that?");
        video4.AddComment("Sunfish lover", "You did not just diss my boi.");
        video4.AddComment("Pufferfish lover", "Guys don't fight it's just sunfish!");
        

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of comments: " + video.NumberOfComments());
            Console.WriteLine("Comments:");
            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                Console.WriteLine("- " + comment.GetCommenterName() + ": " + comment.GetCommentText());
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}