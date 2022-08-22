using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Application.CustomExceptions;

namespace KasaAPP.Core
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate nextTask;

        public GlobalExceptionHandler(RequestDelegate NextTask)
        {
            this.nextTask = NextTask;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await this.nextTask(httpContext);
            }
            catch (System.Exception ex)
            {
                httpContext.Response.ContentType = "application/json";
                object response = null;
                var statusCode = StatusCodes.Status500InternalServerError;

                switch (ex)
                {
                    case ValidationException obj:
                        statusCode = StatusCodes.Status422UnprocessableEntity;
                        response = obj.Errors.Select(x => new
                        {
                            x.PropertyName,
                            x.ErrorMessage
                        });
                        break;
                    case EmptyRequestException obj:
                        statusCode = StatusCodes.Status400BadRequest;
                        response =new
                        {
                           obj.Message
                        };
                    break;
                    case EmailNotSendException obj:
                        statusCode = StatusCodes.Status410Gone;//Gone jer nema vise slanja emaila standardnim nacinom :(
                        response = new
                        {
                            obj.Message
                        };
                        break;
                    case UserAlreadyActiveException obj:
                        statusCode = StatusCodes.Status409Conflict;
                        response = new
                        {
                            obj.Message
                        };
                        break;
                    case UserNotFoundException obj:
                        statusCode = StatusCodes.Status404NotFound;
                        response = new
                        {
                            obj.Message
                        };
                        break;
                    case UnAuthorizedException obj:
                        statusCode = StatusCodes.Status403Forbidden;
                        response = new
                        {
                            obj.Message
                        };
                        break;
                }
                httpContext.Response.StatusCode = statusCode;
                if (response != null)
                {
                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
                    return;
                }
                await Task.FromResult(httpContext.Response);
            }
        }
    }
}
