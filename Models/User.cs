namespace nanatsu.Models
{
    public class User
    {
        public Guid id { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
