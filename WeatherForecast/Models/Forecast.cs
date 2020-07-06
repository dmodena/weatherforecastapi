using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherForecast.Models
{
    [Table("forecast")]
    public class Forecast
    {
        [Column("date")]
        public DateTime Date { get; set; }
        
        [Column("temperatureC")]
        public int TemperatureC { get; set; }

        [Column("temperatureF")]
        public int TemperatureF { get; set; }

        [Column("summary")]
        public string Summary { get; set; }
    }
}