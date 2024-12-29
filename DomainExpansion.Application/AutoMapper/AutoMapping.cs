using AutoMapper;
using DomainExpansion.Communication.Requests;
using DomainExpansion.Communication.Responses;
using DomainExpansion.Domain.Entities;

namespace DomainExpansion.Application.AutoMapper
{
    public class AutoMapping : Profile 
    {
        public AutoMapping()
        {
            RequestToEntity();
            EntityToResponse();
        }

        private void RequestToEntity()
        {
            CreateMap<RequestTransacaoJson, TabTransacao>();          
        }

        private void EntityToResponse()
        {
            CreateMap<TabTransacao, ResponseTransacaoJson>();            
            CreateMap<TabTransacao, ResponseShortTransacaoJson>();            
        }
    }
}
