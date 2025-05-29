using Clean.Architecture.UseCases.Products.Create;

namespace Clean.Architecture.Web.EndPoints.Products;

public class Create(IMediator _mediator)
  : Endpoint<CreateProductRequest, CreateProductResponse>
{
  public override void Configure()
  {
    // Endpoint route
    Post(CreateProductRequest.Route);
    // Without Authentication
    AllowAnonymous();
    // Swagger Documentation
    Summary(Q =>
    {
      Q.ExampleRequest = new CreateProductRequest
      {
        Sku = "SP-001",
        Name = "Sample Product",
        Description = "Product ini sesuatu",
        Price = 10000,
        Quantity = 1,
        Category = "Sample Category",
        Brand = "Sample Brand",
        Barcode = "1234567890123",
        UnitOfMeasure = "Piece | Kilogram | Liter | Box | Lusin | Gram | Ons"
      };
    });
  }

  public override async Task HandleAsync(CreateProductRequest req, CancellationToken ct)
  {
    var result = await _mediator.Send(new CreateProductCommand(
      sku: req.Sku,
      name: req.Name,
      description: req.Description ?? "",
      price: req.Price,
      quantity: req.Quantity,
      imageUrl: req.ImageUrl ?? "",
      category: req.Category ?? "",
      brand: req.Brand ?? "",
      barcode: req.Barcode ?? "",
      unitOfMeasure: req.UnitOfMeasure)
      , ct);

    if (result.IsSuccess)
    {
      Response = new CreateProductResponse(201, req.Name, "Product created successfully");
      return;
    }
  }
}
