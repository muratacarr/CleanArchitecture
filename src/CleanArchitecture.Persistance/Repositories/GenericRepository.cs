using CleanArchitecture.Application.Common.Interfaces.Repositories;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Persistance.Context;

namespace CleanArchitecture.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
