using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.ContributorAggregate;

namespace Clean.Architecture.Core.Interfaces.Products;
public interface IGetList
{
  public Task<Result<IReadOnlyList<Product>>> GetAllProductsAsync(CancellationToken cancellationToken);
}
