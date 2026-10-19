using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OdataRESTAPI.Models;
using OdataRESTAPI.Persistence;
using OdataRESTAPI.Seed;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers()
                .AddOData(options=>
                options.AddRouteComponents("odata",GetEdmModel())
                    .Select()
                    .Filter()
                    .OrderBy());



builder.Services.AddDbContext<OdataDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Helpful only during development
    app.UseODataRouteDebug();
}
var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<OdataDbContext>();
if (!dbContext.Products.Any())
    await ProductsSeeder.SeedAsync(dbContext);

app.UseRouting();
app.MapControllers();

app.Map("/" ,()=>"Hello, world");

app.Run();

static IEdmModel GetEdmModel()
{
    var builder = new ODataConventionModelBuilder();
    builder.EntitySet<Product>("Products");
    return builder.GetEdmModel();
}