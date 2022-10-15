using System.Net;

namespace WeatherForecast.Models
{
    public static class WeatherCodes
    {

        public static string GetWeatherDescription(int weathercode)
        {
            foreach (var item in Weathercodes)
            {
                if (item.Key == weathercode)
                {
                    return item.Value;
                }
            }

            return $"Sorry, we did not find the description for: {weathercode}";

        }


        private static List<KeyValuePair<int, string>> Weathercodes = new List<KeyValuePair<int, string>>
        {

            new KeyValuePair<int, string>(0, "Clear sky"),
            new KeyValuePair<int, string>(1, "Mainly clear"),
            new KeyValuePair<int, string>(2, "Partly cloudy"),
            new KeyValuePair<int, string>(3, "Overcast"),

            new KeyValuePair<int, string>(45, "Fog"),
            new KeyValuePair<int, string>(48, "Depositing rime fog"),

            new KeyValuePair<int, string>(51, "Drizzle: Light intensity"),
            new KeyValuePair<int, string>(53, "Drizzle: moderate intensity"),
            new KeyValuePair<int, string>(55, "Drizzle: dense intensity"),

            new KeyValuePair<int, string>(56, "Freezing Drizzle: Light intensity"),
            new KeyValuePair<int, string>(57, "Freezing Drizzle: Dense intensity"),

            new KeyValuePair<int, string>(61, "Rain: Slight intensity"),
            new KeyValuePair<int, string>(63, "Rain: Moderate intensity"),
            new KeyValuePair<int, string>(65, "Rain: Heavy intensity"),

            new KeyValuePair<int, string>(66, "Freezing Rain: Light intensity"),
            new KeyValuePair<int, string>(67, "Freezing Rain: Heavy intensity"),
            new KeyValuePair<int, string>(71, "Snow fall: Slight intensity"),
            new KeyValuePair<int, string>(73, "Snow fall: Moderate intensity"),
            new KeyValuePair<int, string>(75, "Snow fall: Heavy intensity"),
            new KeyValuePair<int, string>(77, "Snow grains"),

            new KeyValuePair<int, string>(80, "Rain showers: Slight"),
            new KeyValuePair<int, string>(81, "Rain showers: Moderate"),
            new KeyValuePair<int, string>(82, "Rain showers: Violent"),
            new KeyValuePair<int, string>(85, "Snow showers Slight"),
            new KeyValuePair<int, string>(86, "Snow showers Heavy,"),
            new KeyValuePair<int, string>(95, "Thunderstorm: Slight or moderate"),
            new KeyValuePair<int, string>(96, "Thunderstorm with slight and heavy hail"),
            new KeyValuePair<int, string>(99, "Thunderstorm with slight and heavy hail"),
        };
    }
}

