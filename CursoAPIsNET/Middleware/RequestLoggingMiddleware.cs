namespace CursoAPIsNET.Middleware
{
    public class RequestLoggingMiddleware
    {
        //es un middleware personalizado que registra los detalles de cada solicitud HTTP entrante.
        private readonly RequestDelegate _next;

        //Constructor especial para middleware
        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context) {

            //Registrar detalles de la solicitud
            Console.WriteLine($"[Middleware] Request: {context.Request.Path}");

            await _next(context); //Llamar al siguiente middleware en la cadena

            //Registrar detalles de la respuesta
            Console.WriteLine($"[Middleware] Response: {context.Response.StatusCode}");
        }
    }

    public static class RequestLoggingMiddlewareExtensions
    {
        //Extensión para agregar el middleware al pipeline de la aplicación
        public static IApplicationBuilder UseRequestLogging(this IApplicationBuilder app)
           => app.UseMiddleware<RequestLoggingMiddleware>();
    }
}
       
