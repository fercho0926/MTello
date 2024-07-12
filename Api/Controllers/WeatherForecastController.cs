using Data.PdfTempleate;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Api.Controllers
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

            //web page to create pdf form : https://www.docfly.com/


            var pdfFiller = new PdfFormFiller();

            var fieldValues = new Dictionary<string, string>
            {
                { "companyName", "MITLONNNNNNNNNNNNNN" },
                //{ "fieldName2", "Value2" }
            };


            var path = Path.Combine(Directory.GetCurrentDirectory(), "PdfTemplates", "template1.pdf");

            var outputPath = Path.Combine(Directory.GetCurrentDirectory(), "PdfTemplates", "output.pdf");

            pdfFiller.FillPdfForm (path, outputPath, fieldValues);





            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
