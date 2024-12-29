using DomainExpansion.Domain.Repositories;

namespace DomainExpansion.Infrastructure.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DomainExpansionDbContext _dbContext;

        public UnitOfWork(DomainExpansionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}
