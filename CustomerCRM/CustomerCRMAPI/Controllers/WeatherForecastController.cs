using Antra.CustomerCRM.WebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerCRMAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        List<Employee> emps = new List<Employee> {
            new Employee(){Id=1,FirstName = "Smith", Salary=6000,Department="IT"},
            new Employee(){Id=2,FirstName = "Olivia", Salary=6500,Department="IT"},
            new Employee(){Id=3,FirstName = "Daniel", Salary=5600,Department="IT"},
            new Employee(){Id=4,FirstName = "Rochelle", Salary=6300,Department="IT"},
            new Employee(){Id=5,FirstName = "Mia", Salary=6800,Department="IT"} };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return "Welcome to web api.";
        }

        [HttpGet]
        [Route("getname/{name}")]
        public string GetMessageWithName(String name) {
            return "Welcome " + name;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAllEmps()
        {
            //not return IEnumerable, will return IActionResult

            return Ok(emps);
        }

        [HttpGet]
        [Route("GetById/{id:int:max(5):min(1)}")] //dynamic route
        public IActionResult GetById(int Id) 
        {
            return Ok(emps.FirstOrDefault(e => e.Id == Id));
        }

        [HttpGet]
        [Route("GetByNameId/{id}/{name}")]
        // 
        public IActionResult Get(int id, string name) 
        {
            string result = $"Employee name = {name} and id = {id}";
            return Ok(result);
        }
    
        [HttpGet("GetByNameCity")]
        //public IActionResult Get(string city, string name)
        //{
        //    string result = $"Employee name = {name} and city = {city}";
        //    return Ok(result);
        //}
        public IActionResult Get(string city="", string name="")
        {
            string result = "method with query strinf";
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(int id,Employee emp)
        {
           emps.Add(emp);
           return Ok(emps);
        }

    }
}
    