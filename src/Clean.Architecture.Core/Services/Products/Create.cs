using Clean.Architecture.Core.ContributorAggregate;
using Clean.Architecture.Core.Interfaces.Products;

namespace Clean.Architecture.Core.Services.Products;
public class Create(IRepository<Product> _repository,
  //IMediator _mediator,
  ILogger<Create> _logger) : ICreate
{
  public async Task<Result<int>> CreateProductAsync(
    string sku, 
    string name, 
    string description, 
    decimal price, 
    int quantity, 
    string imageUrl, 
    string category, 
    string brand, 
    string barcode, 
    string unitOfMeasure, 
    CancellationToken cancellationToken)
  {
    _logger.LogInformation("Creating product name: {name}", name);
    var product = new Product(
      sku: sku,
      name: name,
      description: description,
      price: price,
      quantity: quantity,
      imageUrl: imageUrl,
      category: category,
      brand: brand,
      barcode: barcode,
      unitOfMeasure: unitOfMeasure,
      createdAt: DateTime.UtcNow,
      createdBy: "SYSTEM" // This should be replaced with the actual user context if available
      );
    await _repository.AddAsync(product);
    _logger.LogInformation("Success creating product name: {name}", name);
    return Result.Success();
  }
}
