using System.ComponentModel.DataAnnotations;

namespace Clean.Architecture.Web.EndPoints.Products;

public class CreateProductRequest
{
  public const string Route = "/product";

  public string Sku { get; set; } = string.Empty;

  [Required]
  public string Name { get; set; } = string.Empty;

  public string? Description { get; set; }

  public decimal Price { get; set; }

  public int Quantity { get; set; }

  public string? ImageUrl { get; set; }

  public string? Category { get; set; }

  public string? Brand { get; set; }

  public string? Barcode { get; set; }

  public string UnitOfMeasure { get; set; } = string.Empty;

  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
