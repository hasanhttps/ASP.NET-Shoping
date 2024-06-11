using DataAccess.DbContexts;
using DataAccess.Repositories.Abstracts;
using Domain.Entities.Concretes;

namespace DataAccess.Repositories.Concretes;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository {

    // Constructor

    public CategoryRepository(ProductManagerDbContext context) : base(context) { 
    
    }
}
