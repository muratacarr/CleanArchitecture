using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace CleanArchitecture.WebApi.Middlewares
{
    public class ErrorMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
			try
			{
				await next(context);
			}
			catch (Exception ex)
			{
				context.Response.ContentType = MediaTypeNames.Application.Json;
				context.Response.StatusCode = 500;

				if (ex.GetType()== typeof(ValidationException))
				{
					
				}
			}
        }
    }
}
