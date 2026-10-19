using Microsoft.EntityFrameworkCore;
using OdataRESTAPI.Models;

namespace OdataRESTAPI.Persistence;

public class OdataDbContext : DbContext
{
    public OdataDbContext(DbContextOptions<OdataDbContext> options):base(options){}
    internal DbSet<Product> Products =>Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfig());
        base.OnModelCreating(modelBuilder);
    }
}