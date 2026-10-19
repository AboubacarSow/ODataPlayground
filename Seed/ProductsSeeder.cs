using OdataRESTAPI.Models;
using OdataRESTAPI.Persistence;

namespace OdataRESTAPI.Seed;

internal class ProductsSeeder
{
    internal static async Task SeedAsync(OdataDbContext context)
    {
        var products = GetProducts();
        await context.AddRangeAsync(products);
        await context.SaveChangesAsync();
    }
    private static Product[] GetProducts()
    {
        return
        [
            new Product("Laptop", 1299.99),
            new Product("Wireless Mouse", 29.99),
            new Product("Keyboard", 79.99),
            new Product("Monitor", 249.99),
            new Product("USB-C Hub", 49.99),
            new Product("Webcam", 89.99),
            new Product("Headphones", 119.99),
            new Product("External SSD", 159.99),
            new Product("Desk Lamp", 34.99),
            new Product("Laptop Stand", 44.99)
        ];
    }
}