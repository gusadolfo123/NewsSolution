using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Contracts.Common
{
    public interface IReadable
    {
        Task<T> GetById<T>(int id) where T : class;
        Task<IEnumerable<T>> GetAll<T>() where T : class; 
    }
}
