using DataAccess.DbContexts;
using Domain.Entities.Concretes;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories.Concretes;

public class ProductRepository : GenericRepository<Product>, IProductRepository {

    // Constructor

    public ProductRepository(ProductManagerDbContext context) : base(context) { 
    
    }
}
