using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestProgram.Pages.Model
{
    public class WeatherResponse
    {
        public GetTemperature Main { get; set; }

        public string Name { get; set; }
    }

    public class GetTemperature
    {
        public float Temp { get; set; }
    }
}
