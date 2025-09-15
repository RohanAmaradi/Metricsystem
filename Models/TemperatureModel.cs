using System.ComponentModel.DataAnnotations;

namespace metricsystem.Models
{
    public class TemperatureModel
    {
        [Required(ErrorMessage = "Please enter a Fahrenheit value.")]
        public double? Fahrenheit { get; set; }

        public double? Celsius { get; set; }

        public double? ConvertToCelsius()
        {
            return Fahrenheit.HasValue ? (Fahrenheit.Value - 32) * 5.0/ 9 : null;
        }
    }
}