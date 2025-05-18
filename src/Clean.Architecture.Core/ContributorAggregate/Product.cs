using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.ContributorAggregate;
public class Product : EntityBase, IAggregateRoot
{
  public string SKU { get; private set; } = string.Empty;
  public string Name { get; private set; } = string.Empty;
  public string Description { get; private set; } = string.Empty;
  public decimal Price { get; private set; } 
  public int Quantity { get; private set; } 
  public string? ImageUrl { get; private set; } 
  public string? Category { get; private set; } 
  public string? Brand { get; private set; } 
  public string? Barcode { get; private set; }
  public string UnitOfMeasure { get; private set; } = string.Empty;
  public DateTime CreatedAt { get; private set; } 
  public DateTime? UpdatedAt { get; private set; }

  // Required by EF Core
  private Product() { }

  public Product(string sku, string name, string description, decimal price, int quantity, string unitOfMeasure)
  {
    SKU = Guard.Against.NullOrEmpty(sku, nameof(sku));
    Name = Guard.Against.NullOrEmpty(name, nameof(name));
    Description = Guard.Against.NullOrEmpty(description, nameof(description));
    Price = Guard.Against.Negative(price);
    Quantity = Guard.Against.Negative(quantity);
    UnitOfMeasure = Guard.Against.NullOrEmpty(unitOfMeasure, nameof(unitOfMeasure));
    CreatedAt = DateTime.UtcNow;
  }
}
