namespace PROJECT_05._05._26.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Loan
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }

        public int MemberId { get; set; }
        public Member? Member { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Fine { get; set; }
    }
}
