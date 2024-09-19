using AspNetCoreWebApiProject1.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbContextOptions;

namespace AspNetCoreWebApiProject1.DataContext
{
    public class DataContext: DbContext
    {
        // constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // DbSet<Movies> property representing the entity set
        // entity set generally aligns with a database table,
        // and an entity corresponds to an individual row within that table
        public DbSet<Movies> Movies { get; set; } = null!;
    }
}
