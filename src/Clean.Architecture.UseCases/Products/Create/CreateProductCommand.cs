using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.UseCases.Products.Create;
public record CreateProductCommand(
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
    DateTime createdAt = default
  ) : Ardalis.SharedKernel.ICommand<Result<string>>;
