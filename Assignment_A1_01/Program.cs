using Assignment_A1_01.Models;
using Assignment_A1_01.Services;

namespace Assignment_A1_01;

class Program
{
    static async Task Main(string[] args)
    {        
        double latitude = 60.674855407867405;
        double longitude = 17.14161302547869;

        Forecast forecast = await new OpenWeatherService().GetForecastAsync(latitude, longitude);

        //Your Code to present each forecast item in a grouped list
        foreach (var i in forecast.Items)
        {
            Console.WriteLine($"City: {forecast.City}");
            Console.WriteLine($"Time: {i.DateTime}");
            Console.WriteLine($"Temp: {i.Temperature}°C");
            Console.WriteLine($"Wind: {i.WindSpeed} m/s");
            Console.WriteLine($"Desc: {i.Description}");
        }
    }
}

