using Domain.Contracts.Common;

namespace Domain.Contracts.Repositories
{
    public interface IRepository : IReadable, IWriteable, IRemovable 
    {
    }
}
