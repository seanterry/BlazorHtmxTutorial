namespace BlazorHtmx.Htmx;

public sealed class HtmxMiddleware( RequestDelegate next )
{
    public Task InvokeAsync( HttpContext httpContext, HtmxContext htmxContext )
    {
        htmxContext.Initialize( httpContext );
        return next( httpContext );
    }
}
