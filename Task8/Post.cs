namespace Task8;

public class Post
{
    public string Title { get; set; }
    public int Likecount { get; set; }
    public string Description { get; set; }
    public List<string> comments = new List<string>();
    public bool IsPublished;

    public string Publish()
    {
        return "The post is published.";
        IsPublished = true;
    }

    public void Like()
    {
      Likecount ++;
    }

    public void Comment(string message)
    {
        comments.Add(message);
    }
    

    
}



