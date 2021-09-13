using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class HistoryRepository : BaseRepository
    {
        public HistoryRepository(DbContext context) : base(context)
        {
        }
    }
}
