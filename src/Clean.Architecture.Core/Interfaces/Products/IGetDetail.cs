using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.ContributorAggregate;

namespace Clean.Architecture.Core.Interfaces.Products;
public interface IGetDetail
{
  public Task<Result<Product>> GetProductByIdAsync(
    string id,
    CancellationToken cancellationToken);
}
