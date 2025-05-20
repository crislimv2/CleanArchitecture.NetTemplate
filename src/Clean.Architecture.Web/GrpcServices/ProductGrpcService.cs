using Clean.Architecture.Web.Protos;
using Grpc.Core;

namespace Clean.Architecture.Web.GrpcServices;

public class ProductGrpcService : ProductService.ProductServiceBase
{
  public override Task<GetProductResponse> GetProductById(GetProductRequest request, ServerCallContext context)
  {
    // Your logic here, example hardcoded response:
    var response = new GetProductResponse
    {
      Id = request.Id,
      Name = "Sample Product",
      Stock = 100,
      Price = 9.99
    };
    return Task.FromResult(response);
  }
}
