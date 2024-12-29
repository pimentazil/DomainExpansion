using DomainExpansion.Application.UseCases.Transacao.Delete;
using DomainExpansion.Application.UseCases.Transacao.GetAll;
using DomainExpansion.Application.UseCases.Transacao.Register;
using DomainExpansion.Communication.Requests;
using DomainExpansion.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DomainExpansion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseTransacaoJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register(
        [FromServices] IRegisterTransacaoUseCase useCase,
        [FromBody] RequestTransacaoJson request)
        {
            var response = await useCase.Execute(request);

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseTransacaoJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetAllExpenses([FromServices] IGetAllTransacaoUseCase useCase)
        {
            var response = await useCase.Execute();

            if (response.transactions.Count != 0)
                return Ok(response);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(
        [FromServices] IDeleteTransacaoUseCase useCase,
        [FromRoute] int id)
        {
            await useCase.Execute(id);

            return NoContent();
        }
    }
}
