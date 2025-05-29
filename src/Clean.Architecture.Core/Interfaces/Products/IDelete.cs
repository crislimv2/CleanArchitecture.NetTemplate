using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Interfaces.Products;
public interface IDelete
{
  public Task<Result<int>> DeleteProductAsync(
    string id,
    CancellationToken cancellationToken);
}
