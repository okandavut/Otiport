﻿using System.Net;
using Otiport.API.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Otiport.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<ExceptionFilter> _logger;
        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;
            _logger.LogError($"Something went wrong", context.Exception);

            var response = context.HttpContext.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int) HttpStatusCode.InternalServerError;

            response.WriteAsync(JsonConvert.SerializeObject(context.Exception.MapToErrorResponse()));
        }
    }
}
