using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class WeatherRepository : BaseRepository
    {
        public WeatherRepository(DbContext context) : base(context)
        {
        }
    }
}
