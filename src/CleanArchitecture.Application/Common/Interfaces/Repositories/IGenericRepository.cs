using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Common.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<T> GetByIdAsync(string id,CancellationToken cancellationToken);

        Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    }
}
