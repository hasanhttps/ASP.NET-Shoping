using DataAccess.DbContexts;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new() {
    
    // Fields
    
    protected readonly ProductManagerDbContext _context;

    // Constructor

    public GenericRepository(ProductManagerDbContext context) {
        _context = context;
    }

    public async Task AddAsync(T entity) {
        await _context.Set<T>().AddAsync(entity);
        await SaveChanges();
    }

    public async Task DeleteAsync(int id) {
        var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        if (entity != null) _context.Set<T>().Remove(entity);
        await SaveChanges();
    }

    public async Task<List<T>> GetAllAsync() {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id) {
        return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task SaveChanges()  { 
        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity) {
        _context.Set<T>().Update(entity);
        await SaveChanges();
    }
}
