using DomainExpansion.Domain.Entities;

namespace DomainExpansion.Domain.Repositories.Transacao
{
    public interface ITransacaoWriteOnlyRepository
    {
        Task<List<TabTransacao>> GetAll();
        Task Add(Entities.TabTransacao tabTransacao);
        Task Delete(int id);
    }
}
