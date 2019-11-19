using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Weatherforecast
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; } 
        
        [JsonProperty("temperatureC")]
        public int TemperatureC { get; set; } 
        
        [JsonProperty("temperatureF")]
        public int TemperatureF { get; set; }  
        
        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}
