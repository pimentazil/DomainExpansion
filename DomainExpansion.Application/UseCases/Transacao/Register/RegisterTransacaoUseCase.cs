using AutoMapper;
using DomainExpansion.Communication.Requests;
using DomainExpansion.Communication.Responses;
using DomainExpansion.Domain.Entities;
using DomainExpansion.Domain.Repositories;
using DomainExpansion.Domain.Repositories.Transacao;

namespace DomainExpansion.Application.UseCases.Transacao.Register
{
    public class RegisterTransacaoUseCase : IRegisterTransacaoUseCase
    {
        private readonly ITransacaoWriteOnlyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RegisterTransacaoUseCase(
            ITransacaoWriteOnlyRepository repository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseTransacaoJson> Execute(RequestTransacaoJson request)
        {
            var transaction = _mapper.Map<TabTransacao>(request);

            await _repository.Add(transaction);

            await _unitOfWork.Commit();

            return _mapper.Map<ResponseTransacaoJson>(transaction);
        } 
    }
}
