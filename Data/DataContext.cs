using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sonata_eStore.Models;

namespace Sonata_eStore.Data
{
    public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            { }
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
        }
    }

