namespace BlazorHtmx.Htmx;

public sealed class HtmxContext
{
    public HtmxMode Mode { get; private set; }

    public void Initialize( HttpContext httpContext )
    {
        bool isHtmx = httpContext.Request.Headers.ContainsKey( "HX-Request" );
        bool isBoosted = isHtmx && httpContext.Request.Headers.ContainsKey( "HX-Boosted" );

        Mode =
            isBoosted ? HtmxMode.Boosted :
            isHtmx ? HtmxMode.On :
            HtmxMode.Off;
    }
}
