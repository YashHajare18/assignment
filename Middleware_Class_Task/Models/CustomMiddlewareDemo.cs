namespace Middleware_Class_Task.Models
{
    public class CustomMiddlewareDemo : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from Custom Middleware");

            await next(context);

        }
    }
}
