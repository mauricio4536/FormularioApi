using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Exemplo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet(Name = "Contribuintes")]
        public IEnumerable<object> Contribuintes()
        {
            return JsonConvert.DeserializeObject<IEnumerable<object>>("[{'ContribuinteID': 1,  'PrimeiroNome': 'Ola', 'SobreNome': 'mundo', 'Email': 'jfkjgdokl@kgklf.com', 'Celular': '895859295', 'CPF': '9599746681', 'RendaAnual': 826.6, 'Genero': 1 }\r\n,{ 'ContribuinteID': 1,  'PrimeiroNome': 'Ola', 'SobreNome': 'mundo', 'Email': 'jfkjgdokl@kgklf.com', 'Celular': '895859295', 'CPF': '9599746681', 'RendaAnual': 826.6, 'Genero': 1 }\r\n,{ 'ContribuinteID': 1,  'PrimeiroNome': 'Ola', 'SobreNome': 'mundo', 'Email': 'jfkjgdokl@kgklf.com', 'Celular': '895859295', 'CPF': '9599746681', 'RendaAnual': 826.6, 'Genero': 1 }]\r\n");
        }
    }
}