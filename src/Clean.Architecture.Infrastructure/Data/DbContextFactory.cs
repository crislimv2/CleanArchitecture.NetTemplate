using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace Clean.Architecture.Infrastructure.Data;
public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
  public AppDbContext CreateDbContext(string[] args)
  {
    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
    optionsBuilder.UseNpgsql("Server=localhost;Database=inventory-product;User Id=postgres;Password=123;");
    return new AppDbContext(optionsBuilder.Options, null);
  }
}
