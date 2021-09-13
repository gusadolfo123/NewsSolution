using System.Threading.Tasks;

namespace Domain.Contracts.Common
{
    public interface IRemovable
    {
        Task<bool> Remove<T>(int id) where T : class;
    }
}
