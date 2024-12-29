using DomainExpansion.Communication.Responses;
using DomainExpansion.Exception.ExceptionBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DomainExpansion.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is DomainExpansionException)
            {
                HandleProjectException(context);
            }
            else
            {
                ThrowUnkowError(context);
            }
        }

        private void HandleProjectException(ExceptionContext context)
        {
            var excep = (DomainExpansionException)context.Exception;
            var errorResponse = new ResponseErrorJson(excep.GetErrors());

            context.HttpContext.Response.StatusCode = excep.StatusCode;
            context.Result = new ObjectResult(errorResponse);
        }

        private void ThrowUnkowError(ExceptionContext context)
        {
            var errorResponse = new ResponseErrorJson("Erro desconhecido");

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorResponse);
        }
    }
}
