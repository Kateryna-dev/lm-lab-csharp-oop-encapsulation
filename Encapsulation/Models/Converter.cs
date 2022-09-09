using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    public static class Converter
    {
        public static double ConvertCelsiusToFahrenheit(double celsiusTemperature) => (9.0 / 5.0) * celsiusTemperature + 32;
    }
}
