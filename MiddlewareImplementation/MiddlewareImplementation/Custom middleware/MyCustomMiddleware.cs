
namespace MiddlewareImplementation.Custom_middleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // before loginc
            await context.Response.WriteAsync("Hello from MyCustomMiddleware\n");
            // we invoke the subsiquent middleware in the pipeline
            await next(context);
            // after logic 
            await context.Response.WriteAsync("Goodbye from MyCustomMiddleware\n");
        }
    }

    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyCustomMiddleware>();
        }
    }
}
