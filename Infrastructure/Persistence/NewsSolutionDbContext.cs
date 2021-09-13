using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class NewsSolutionDbContext : DbContext 
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<History> Histories { get; set; }

        public NewsSolutionDbContext(DbContextOptions options) : base(options)
        {
        }

        protected NewsSolutionDbContext()
        {
        }
    }
}
