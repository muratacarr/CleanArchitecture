using System.Text.Json;

namespace CleanArchitecture.WebApi.Middlewares;

public sealed class ErrorResult
{
    public string Message { get; set; }
}

public class ErrorStatusCode
{
    public int StatusCode { get; set; }
    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public sealed class ValidationErrorDetails : ErrorStatusCode
{
    public IEnumerable<string> Errors { get; set; }
}