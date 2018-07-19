using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MaviNokta.Models;

namespace MaviNokta.API.Extensions
{
    public static class ExceptionExtensions
    {
        public static ErrorResponse MapToErrorResponse(this Exception ex)
        {
            var response = new ErrorResponse()
            {
                ErrorCode = (int)HttpStatusCode.InternalServerError,
                ErrorMessage = ex.Message
            };

            while (ex != null)
            {
                response.Errors.Add(new Error()
                {
                    Title = ex.Message,
                    Detail = ex.StackTrace
                });
                ex = ex.InnerException;
            }

            return response;
        }
    }
}
