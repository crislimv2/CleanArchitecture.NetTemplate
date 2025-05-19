using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.ContributorAggregate;
[Table("products")]
public class Product : EntityBase, IAggregateRoot
{
  [Column("sku")]
  public string SKU { get; private set; } = string.Empty;
  [Column("name")]
  public string Name { get; private set; } = string.Empty;
  [Column("description")]
  public string Description { get; private set; } = string.Empty;
  [Column("price")]
  public decimal Price { get; private set; }
  [Column("quantity")]
  public int Quantity { get; private set; }
  [Column("ImageUrl")]
  public string? ImageUrl { get; private set; }
  [Column("category")]
  public string? Category { get; private set; }
  [Column("brand")]
  public string? Brand { get; private set; }
  [Column("barcode")]
  public string? Barcode { get; private set; }
  [Column("unitOfMeasure")]
  public string UnitOfMeasure { get; private set; } = string.Empty;
  [Column("createdAt")]
  public DateTime CreatedAt { get; private set; }
  [Column("updatedAt")]
  public DateTime? UpdatedAt { get; private set; }

  // Required by EF Core
  protected Product() { }

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
