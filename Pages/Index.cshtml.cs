using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTestProgram.Pages.Model;
using System.Net;
using System.IO;
using Newtonsoft.Json;



namespace MyTestProgram.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string testWeather;

        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            GetWeather(); 
        }

        WeatherResponse pogoda { get; set; }
        public void GetWeather()
        {
            Weather weather = new Weather();

            string respone = weather.TestWeather();

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(respone);

            testWeather = $"Погода в {weatherResponse.Name} состовляет {weatherResponse.Main.Temp} градусов цельсия";


        }

        


    }
}
