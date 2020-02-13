using Microsoft.EntityFrameworkCore;

namespace ILoveCats.Models
{
    public class CatContext : DbContext
    {
        public CatContext(DbContextOptions<CatContext> options)
            : base(options)
        {
        }

        public DbSet<CatContext> Cats { get; set; }
    }
}
