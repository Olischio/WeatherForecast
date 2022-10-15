using System.Net;

namespace WeatherForecast.Models
{

    public class WeatherCodeInfo
    {
        public WeatherCodeInfo(int weatherCode, string description, string image="")
        {
            WeatherCode = weatherCode;
            Description = description;
            Image = image;  
        }

        public int WeatherCode { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }

    public static class WeatherCodes
    {

        public static string GetWeatherDescription(int weathercode)
        {
            foreach (var item in Weathercodes)
            {
                if (item.WeatherCode == weathercode)
                {
                   

                    return weathercode +" "+ item.Description;

                }
            }

            return $"Sorry, we did not find the description for: {weathercode}";

        }

        public static string GetWeatherImage(int weathercode)
        {
            foreach (var item in Weathercodes)
            {
                if (item.WeatherCode == weathercode && !string.IsNullOrEmpty(item.Image))
                {
                    return item.Image + ".svg";
                }
            }
            return string.Empty;
        }



        private static List<WeatherCodeInfo> Weathercodes = new List<WeatherCodeInfo>
        {

            new WeatherCodeInfo(0, "Clear sky", "01d"),
            new WeatherCodeInfo(1, "Mainly clear", "02d"),
            new WeatherCodeInfo(2, "Partly cloudy", "03d"),
            new WeatherCodeInfo(3, "Overcast", "04"),

            new WeatherCodeInfo(45, "Fog"),
            new WeatherCodeInfo(48, "Depositing rime fog"),
              
            new WeatherCodeInfo(51, "Drizzle: Light intensity"),
            new WeatherCodeInfo(53, "Drizzle: moderate intensity"),
            new WeatherCodeInfo(55, "Drizzle: dense intensity"),
               
            new WeatherCodeInfo(56, "Freezing Drizzle: Light intensity"),
            new WeatherCodeInfo(57, "Freezing Drizzle: Dense intensity"),

            new WeatherCodeInfo(61, "Rain: Slight intensity"),
            new WeatherCodeInfo(63, "Rain: Moderate intensity"),
            new WeatherCodeInfo(65, "Rain: Heavy intensity"),
               
            new WeatherCodeInfo(66, "Freezing Rain: Light intensity"),
            new WeatherCodeInfo(67, "Freezing Rain: Heavy intensity"),
            new WeatherCodeInfo(71, "Snow fall: Slight intensity"),
            new WeatherCodeInfo(73, "Snow fall: Moderate intensity"),
            new WeatherCodeInfo(75, "Snow fall: Heavy intensity"),
            new WeatherCodeInfo(77, "Snow grains"),
                
            new WeatherCodeInfo(80, "Rain showers: Slight", "05d"),
            new WeatherCodeInfo(81, "Rain showers: Moderate"),
            new WeatherCodeInfo(82, "Rain showers: Violent"),
            new WeatherCodeInfo(85, "Snow showers Slight"),
            new WeatherCodeInfo(86, "Snow showers Heavy,"),
            new WeatherCodeInfo(95, "Thunderstorm: Slight or moderate"),
            new WeatherCodeInfo(96, "Thunderstorm with slight and heavy hail"),
            new WeatherCodeInfo(99, "Thunderstorm with slight and heavy hail"),
        };
    }
}

