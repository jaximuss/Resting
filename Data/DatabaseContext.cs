using Microsoft.EntityFrameworkCore;
using Resting.Models;
using System;

namespace Resting.Data
{
    public class DatabaseContext :DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        // Add DbSets for other entities
    }
}
