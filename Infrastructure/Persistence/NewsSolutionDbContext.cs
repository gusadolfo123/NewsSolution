using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
