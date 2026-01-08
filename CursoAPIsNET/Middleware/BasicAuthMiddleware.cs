using System.Net.Http.Headers;

namespace CursoAPIsNET.Middleware
{
    public class BasicAuthMiddleware
    {
        //es un middleware personalizado que implementa autenticación básica para solicitudes HTTP entrantes.
        private readonly RequestDelegate _next;

        private const string DemoUsername = "admin";
        private const string DemoPassword = "1234";

        //Constructor especial para middleware
        public BasicAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //método InvokeAsync que maneja la lógica de autenticación básica.
        public async Task InvokeAsync(HttpContext context) {

            try
            {
                //Permitir acceso a Swagger y OpenAPI sin autenticación
                if (context.Request.Path.Value.Contains("swagger")
                    || context.Request.Path.Value.Contains("scalar")
                    || context.Request.Path.Value.Contains("openapi"))
                {
                    await _next(context);
                    return;
                }

                //Verificar si el encabezado de autorización está presente
                var authHeader = AuthenticationHeaderValue.Parse(context.Request.Headers["Authorization"]);

                //Descifrar las credenciales de autenticación básica
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter ?? string.Empty);
                //realizar la separación entre usuario y contraseña
                //El segundo parámetro '2' limita la cantidad de subcadenas devueltas a 2, lo que significa que la cadena se dividirá en dos partes: el nombre de usuario y la contraseña.
                var credentials = System.Text.Encoding.UTF8.GetString(credentialBytes).Split(':', 2);

                var username = credentials[0];
                var password = credentials[1];

                //Verificar las credenciales
                if (username == DemoUsername && password == DemoPassword)
                {
                    //Credenciales válidas, continuar con la siguiente etapa del pipeline
                    await _next(context);
                }

            }
            catch (Exception)
            {
                //Credenciales inválidas, devolver 401 Unauthorized
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized");
                
            }
           
            
        }
    }

    // Extensión para agregar el middleware al pipeline de la aplicación
    public static class BasicAuthMiddlewareExtensions
    {
        //Extensión para agregar el middleware al pipeline de la aplicación
        public static IApplicationBuilder UseBasicAuth(this IApplicationBuilder app)
           => app.UseMiddleware<BasicAuthMiddleware>();
    }
}
