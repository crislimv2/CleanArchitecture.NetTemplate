using Clean.Architecture.Web.Configurations;
using Clean.Architecture.Web.GrpcServices;

var builder = WebApplication.CreateBuilder(args);

var logger = Log.Logger = new LoggerConfiguration()
  .Enrich.FromLogContext()
  .WriteTo.Console()
  .CreateLogger();

logger.Information("Starting web host");

builder.AddLoggerConfigs();

var appLogger = new SerilogLoggerFactory(logger)
    .CreateLogger<Program>();

builder.Services.AddOptionConfigs(builder.Configuration, appLogger, builder);
builder.Services.AddServiceConfigs(appLogger, builder);

builder.Services.AddFastEndpoints()
                .SwaggerDocument(o =>
                {
                  o.ShortSchemaNames = true;
                });
builder.Services.AddGrpc();

#if (aspire)
builder.AddServiceDefaults();
#endif

var app = builder.Build();

await app.UseAppMiddlewareAndSeedDatabase();
app.MapGrpcService<ProductGrpcService>();
app.MapGet("/", () => "Use a gRPC client to communicate.");
app.Run();

// Make the implicit Program.cs class public, so integration tests can reference the correct assembly for host building
public partial class Program { }
