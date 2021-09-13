using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class ArticleRepository : BaseRepository
    {
        public ArticleRepository(DbContext context) : base(context)
        {
        }
    }
}
