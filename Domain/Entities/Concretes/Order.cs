using Domain.Entities.Common;
using Domain.Entities.Abstracts;

namespace Domain.Entities.Concretes;

public class Order : BaseEntity, IEntity {

    // Fields

    public int Quantity { get; set; }

    // Foreign Key Id

    public int ProductId { get; set; }

    // Navigation Properties

    public virtual ICollection<Product> Products { get; set;}
}
