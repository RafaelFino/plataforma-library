namespace LibraryApp.Domains
{       
    public class Book(int id, string title, string author)
    {
        public int Id { get; } = id;
        public string Title { get; } = title;
        public string Author { get; } = author;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime LaunchDate { get; set; }
        public string? Category { get; set; }
        public string? Language { get; set; }
        public string? Publisher { get; set; }
        public int Pages { get; set; }
        public string? Description { get; set; }
    }
}