namespace nanatsu.Models
{
    public class Post
    {
        public Guid id { get; set; }
        public string? title { get; set; }
        public string? body { get; set; }
        public int status { get; set; } = 1;
        public Guid author { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
