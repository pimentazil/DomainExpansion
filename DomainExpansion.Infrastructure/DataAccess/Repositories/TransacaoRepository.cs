using DomainExpansion.Domain.Entities;
using DomainExpansion.Domain.Repositories.Transacao;
using Microsoft.EntityFrameworkCore;

namespace DomainExpansion.Infrastructure.DataAccess.Repositories
{
    internal class TransacaoRepository : ITransacaoWriteOnlyRepository
    {
        private readonly DomainExpansionDbContext _dbContext;

        public TransacaoRepository(DomainExpansionDbContext dbContext) => _dbContext = dbContext;

        public async Task Add(TabTransacao transacao)
        {
            await _dbContext.TabTransacao.AddAsync(transacao);
        }

        public async Task Delete(int id)
        {
            var transacToRemove = await _dbContext.TabTransacao.FindAsync(id);
            _dbContext.TabTransacao.Remove(transacToRemove!);
        }

        public async Task<List<TabTransacao>> GetAll()
        {
            return await _dbContext.TabTransacao.AsNoTracking().ToListAsync();
        }
    }
}
