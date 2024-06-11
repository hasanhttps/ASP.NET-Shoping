using Domain.Entities.Concretes;

namespace WebApp.Models;

public class ProductVM {
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public List<Category> Categories { get; set; }
}
