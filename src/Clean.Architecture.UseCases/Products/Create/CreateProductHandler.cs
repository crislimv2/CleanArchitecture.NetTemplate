using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.ContributorAggregate;
using Clean.Architecture.Core.Interfaces.Products;

namespace Clean.Architecture.UseCases.Products.Create;
public class CreateProductHandler(IRepository<Product> _repository
  //,ICacheService _cache
  ) : ICommandHandler<CreateProductCommand, Result<string>>
{
  public async Task<Result<string>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
  {
    var newProduct = new Product(
      sku: request.sku,
      name: request.name,
      description: request.description,
      price: request.price,
      quantity: request.quantity,
      imageUrl: request.imageUrl,
      category: request.category,
      brand: request.brand,
      barcode: request.barcode,
      unitOfMeasure: request.unitOfMeasure,
      createdAt: DateTime.UtcNow,
      createdBy: "SYSTEM" // This should be replaced with the actual user context if available
    );
    await _repository.AddAsync(newProduct, cancellationToken);
    return Result.Success("Success created product");
  }
}
