using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Interfaces.Products;
public interface ICreate
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
    CancellationToken cancellationToken);
}
