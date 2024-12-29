using DomainExpansion.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomainExpansion.Infrastructure.DataAccess
{
    public class DomainExpansionDbContext : DbContext
    {
        public DomainExpansionDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TabTransacao> TabTransacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
