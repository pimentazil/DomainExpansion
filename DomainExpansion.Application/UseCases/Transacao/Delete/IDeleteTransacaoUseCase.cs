namespace DomainExpansion.Application.UseCases.Transacao.Delete
{
    public interface IDeleteTransacaoUseCase
    {
        Task Execute(int id);
    }
}
