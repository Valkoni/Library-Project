using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROJECT_05._05._26.Models;

namespace PROJECT_05._05._26.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<PROJECT_05._05._26.Models.Author> Author { get; set; } = default!;
        public DbSet<PROJECT_05._05._26.Models.Book> Book { get; set; } = default!;
        public DbSet<PROJECT_05._05._26.Models.BookAuthor> BookAuthor { get; set; } = default!;
        public DbSet<PROJECT_05._05._26.Models.Loan> Loan { get; set; } = default!;
        public DbSet<PROJECT_05._05._26.Models.Member> Member { get; set; } = default!;
    }
}
