namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        } 

        public string CreateWeatherMessage()
        {
            double newTemp = Converter.ConvertCelsiusToFahrenheit(_temperature);
            return $"I am in {_location} and it is {CheckLocation(_location)}. {CheckTemperature(_temperature)}. The temperature in Fahrenheit is {newTemp}.";
        }

        public static string CheckLocation(string location) => location switch
            {
                "London" => "🌦",
                "California" => "🌅",
                "Cape Town" => "🌤",
                _ => "🔆",
            };

        public static string CheckTemperature(double temperature) => temperature switch
            {
                > 30 => "It's too hot 🥵!",
                < 10 => "It's too cold 🥶!",
                _ => "Ahhh...it's just right 😊!",
            };
    }
}
