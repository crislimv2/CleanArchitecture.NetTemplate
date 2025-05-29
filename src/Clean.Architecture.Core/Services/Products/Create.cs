using Clean.Architecture.Core.ContributorAggregate;
using Clean.Architecture.Core.Interfaces.Products;

namespace Clean.Architecture.Core.Services.Products;
public class Create(IRepository<Product> _repository,
  IMediator _mediator,
  ILogger<Create> _logger) : ICreate
{
  public Task<Result<int>> CreateProductAsync(
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
    var product = new Product(sku, name, description, price, quantity, unitOfMeasure)
    {
      ImageUrl = imageUrl,
      Category = category,
      Brand = brand,
      Barcode = barcode
    };

  }
}
