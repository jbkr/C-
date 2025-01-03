// serialization
// int a = 100
// string b = "abc"
// 100abc - serialize
// 복합 데이터(클래스) 형식 지원

// unity
// PlayerPrefs
// Save, Load
// class -> json -> class

using System.Text.Json;

namespace SerializeBasic
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelcius { get; set; }
        public string? Summary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelcius = 25,
                Summary = "Hot"
            };

            string fileName = "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}

