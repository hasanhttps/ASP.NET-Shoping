using DataAccess.DbContexts;
using DataAccess.Repositories.Abstracts;
using Domain.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concretes;

public class OrderRepository : GenericRepository<Order>, IOrderRepository {

    // Constructor

    public OrderRepository(ProductManagerDbContext context) : base(context) { 
    
    }
}
