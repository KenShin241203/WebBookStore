namespace WebBookStore.Models
{
    public class BookImage
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string BookId { get; set; }
        public Book? Book { get; set; }
    }
}
