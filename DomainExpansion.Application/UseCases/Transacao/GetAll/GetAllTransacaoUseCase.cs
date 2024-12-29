using AutoMapper;
using DomainExpansion.Communication.Responses;
using DomainExpansion.Domain.Repositories.Transacao;

namespace DomainExpansion.Application.UseCases.Transacao.GetAll
{
    public class GetAllTransacaoUseCase : IGetAllTransacaoUseCase
    {
        private readonly ITransacaoWriteOnlyRepository _repository;
        private readonly IMapper _mapper;

        public GetAllTransacaoUseCase(
            ITransacaoWriteOnlyRepository repository, 
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResponseTransacaoJson> Execute()
        {
            var result = await _repository.GetAll();

            return new ResponseTransacaoJson
            {
                transactions = _mapper.Map<List<ResponseShortTransacaoJson>>(result)
            };
        }
    }
}
