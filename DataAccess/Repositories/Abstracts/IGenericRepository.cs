using Domain.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts;

public interface IGenericRepository<T> where T : IEntity, new() {
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task Update(T entity);
    Task DeleteAsync(int id);
    Task SaveChanges();
    Task<T> GetByIdAsync(int id);
}