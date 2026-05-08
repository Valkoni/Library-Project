namespace PROJECT_05._05._26.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string? Title { get; set; }

        public string? Genre { get; set; }

        public int YearPublished { get; set; }

        public List<BookAuthor>? BookAuthors { get; set; }
        public List<Loan>? Loans { get; set; }
    }

}
