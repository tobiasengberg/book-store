using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

public class ProductContext : IdentityDbContext
{
    public ProductContext(DbContextOptions<ProductContext> options) : base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<CustomerProfile> CustomerProfiles { get; set; }

}