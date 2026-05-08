namespace PROJECT_05._05._26.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Author
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        public string? Nationality { get; set; }

        public List<BookAuthor>? BookAuthors { get; set; }
    }
}
