using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
namespace HD.Station.OrchardCore.Modular.ClassLabrarry1
{
    public class Startup
    {
        public void Configure(IEndpointRouteBuilder endpoint)
        {
            endpoint.MapGet("/c", async context =>
            {
                await context.Response.WriteAsync("hello modular library c 2");
            });
        }
    }
}
