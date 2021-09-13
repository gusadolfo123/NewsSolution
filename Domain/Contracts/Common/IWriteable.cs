using System.Threading.Tasks;

namespace Domain.Contracts.Common
{
    public interface IWriteable
    {
        Task<T> Create<T>(T entity) where T : class;
        Task<bool> Update<T>(T entity) where T : class;
    }
}
