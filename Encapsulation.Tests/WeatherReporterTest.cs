using FluentAssertions;
using Encapsulation.Models;

namespace Encapsulation.Tests
{
    public class WeatherReporterTes
    {
        [Test]
        public void CreateWeatherMessage_Shoud_Return_Message()
        {
            var weatherReporter = new WeatherReporter("London", 22);
            string expectedResult = $"I am in London and it is 🌦. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 71,6.";
            weatherReporter.CreateWeatherMessage().Should().Be(expectedResult);
        }

        [Test]
        public void CheckLocation_Shoud_Return_Message()
        {
            WeatherReporter.CheckLocation("London").Should().Be("🌦");
        }

        [Test]
        public void CheckTemperature_Shoud_Return_Message()
        {
            WeatherReporter.CheckTemperature(40).Should().Be("It's too hot 🥵!");
        }
    }
}
