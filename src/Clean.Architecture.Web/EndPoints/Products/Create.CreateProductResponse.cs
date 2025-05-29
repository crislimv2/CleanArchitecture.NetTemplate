namespace Clean.Architecture.Web.EndPoints.Products;

public class CreateProductResponse
{
  public int StatusCode { get; set; }
  public string Name { get; set; } 
  public string Message { get; set; }

  public CreateProductResponse(int statusCode, string name, string message)
  {
    StatusCode = statusCode;
    Name = name;
    Message = message;
  }

}
