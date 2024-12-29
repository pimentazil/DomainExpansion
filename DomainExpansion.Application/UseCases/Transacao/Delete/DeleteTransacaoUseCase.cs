using DomainExpansion.Domain.Repositories;
using DomainExpansion.Domain.Repositories.Transacao;

namespace DomainExpansion.Application.UseCases.Transacao.Delete
{
    public class DeleteTransacaoUseCase : IDeleteTransacaoUseCase   
    {
        private readonly ITransacaoWriteOnlyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteTransacaoUseCase(
            ITransacaoWriteOnlyRepository repository,
            IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(int id)
        {
            await _repository.Delete(id);

            await _unitOfWork.Commit();
        }
    }
}
