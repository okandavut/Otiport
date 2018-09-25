using System;
using System.Net;
using Otiport.API.Models;

namespace Otiport.API.Extensions
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
