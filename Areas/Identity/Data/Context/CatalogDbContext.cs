using Catalog.Areas.Identity.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Areas.Identity.Data.Context;

public class CatalogDbContext : IdentityDbContext<ApplicationUser>
{
    //public DbSet<ApplicationUser> Users { get; set; }

    public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
