namespace CrochetbookBackend.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string? TextContent { get; set; }
        public string? Url { get; set; }
    }
}
