using Microsoft.AspNetCore.Mvc;

namespace CursoAPIsNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        //es una variable de instancia que no se usa en el código proporcionado
        private static WeatherForecast[] ListWeatherForecast;

        private ILogger<WeatherForecastController> logger;

        public WeatherForecastController( ) {

            ListWeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
            .ToArray();
        }

        /// <summary>
        /// Returna una lista de pronósticos del tiempo
        /// </summary>
        /// <returns></returns>

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get([FromServices] ILogger<WeatherForecastController> logger)
        {
            //LogInformation registra un mensaje informativo en el sistema de logging
            logger.LogInformation("Se ha ejecutado el método Get de WeatherForecastController");
            return ListWeatherForecast;
        }


        /// <summary>
        /// return un pronóstico del tiempo por posición
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        //es un método que devuelve un pronóstico del tiempo basado en una posición dada
        [HttpGet]
        [Route("{id}")]
        //ActionResult permite devolver diferentes tipos de respuestas HTTP
        public ActionResult<WeatherForecast> GetByPosition(int id)
        {
            if (id > 5 || id < 0) {
                //BadRequest devuelve un código de estado HTTP 400 indicando que la solicitud es inválida
                return BadRequest();
            }

            //Ok devuelve un código de estado HTTP 200 junto con el pronóstico del tiempo solicitado
            return Ok(ListWeatherForecast[id]);
        }
    }
}
