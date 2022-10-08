using Microsoft.EntityFrameworkCore;
using SanalBorsa.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Crypto> Cryptos { get; set; }
        public DbSet<Golden> Goldens { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<ExChangeRates> ExChangeRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
