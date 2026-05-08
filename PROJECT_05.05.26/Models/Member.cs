namespace PROJECT_05._05._26.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Member
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string? FullName { get; set; }

        public string? Email { get; set; }

        public DateTime RegisteredOn { get; set; }

        public List<Loan>? Loans { get; set; }
    }
}
