using FluentValidation;

namespace Clean.Architecture.Web.EndPoints.Products;

public class CreateProductValidator : Validator<CreateProductRequest>
{
  public CreateProductValidator()
  {
    RuleFor(x => x.Sku)
        //.NotEmpty().WithMessage("SKU is required.")
        .MaximumLength(50).WithMessage("SKU tidak boleh lebih dari 50 characters.");
    RuleFor(x => x.Name)
        .NotEmpty().WithMessage("Name harus diisi.")
        .MaximumLength(100).WithMessage("Name tidak boleh lebih dari 100 characters.");
    RuleFor(x => x.Description)
        .MaximumLength(100).WithMessage("Description tidak boleh lebih dari 100 characters.");
    RuleFor(x => x.Price)
        .GreaterThan(0).WithMessage("Price harus lebih dari 0.");
    RuleFor(x => x.Quantity)
        .GreaterThanOrEqualTo(0).WithMessage("Quantity tidak boleh negative.");
    RuleFor(x => x.ImageUrl)
        .MaximumLength(200).WithMessage("Image URL tidak boleh lebih dari 200 characters.");
    RuleFor(x => x.Category)
        .NotEmpty().WithMessage("Category harus diisi.")
        .MaximumLength(50).WithMessage("Category tidak boleh lebih dari 50 characters.");
    RuleFor(x => x.Brand)
        .NotEmpty().WithMessage("Brand harus diisi.")
        .MaximumLength(50).WithMessage("Brand tidak boleh lebih dari 50 characters.");
    RuleFor(x => x.Barcode)
        .MaximumLength(100).WithMessage("Barcode tidak boleh lebih dari 100 characters.");
    RuleFor(x => x.UnitOfMeasure)
        .NotEmpty().WithMessage("Unit of Measure harus diisi.")
        .MaximumLength(100).WithMessage("Unit of Measure tidak boleh lebih dari 100 characters.");
  }
}
