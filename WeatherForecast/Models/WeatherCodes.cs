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
                    return item.Description;
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
            // Kodene og beskrivelsene er fra https://open-meteo.com/en/docs WMO Weather interpretation codes (WW)

            new WeatherCodeInfo(0, "Clear sky", "01d"),
            new WeatherCodeInfo(1, "Mainly clear", "02d"),
            new WeatherCodeInfo(2, "Partly cloudy", "03d"),
            new WeatherCodeInfo(3, "Overcast", "04"),

            new WeatherCodeInfo(45, "Fog", "15"),
            new WeatherCodeInfo(48, "Depositing rime fog", "15"),
              
            new WeatherCodeInfo(51, "Drizzle: Light intensity", "05d"),
            new WeatherCodeInfo(53, "Drizzle: moderate intensity", "05d"),
            new WeatherCodeInfo(55, "Drizzle: dense intensity", "05d"),
               
            new WeatherCodeInfo(56, "Freezing Drizzle: Light intensity", "12"),
            new WeatherCodeInfo(57, "Freezing Drizzle: Dense intensity", "12"),

            new WeatherCodeInfo(61, "Rain: Slight intensity", "09"),
            new WeatherCodeInfo(63, "Rain: Moderate intensity", "10"),
            new WeatherCodeInfo(65, "Rain: Heavy intensity", "10"),
               
            new WeatherCodeInfo(66, "Freezing Rain: Light intensity", "12"),
            new WeatherCodeInfo(67, "Freezing Rain: Heavy intensity", "12"),
            new WeatherCodeInfo(71, "Snow fall: Slight intensity", "13"),
            new WeatherCodeInfo(73, "Snow fall: Moderate intensity", "13"),
            new WeatherCodeInfo(75, "Snow fall: Heavy intensity", "13"),
            new WeatherCodeInfo(77, "Snow grains"),
                
            new WeatherCodeInfo(80, "Rain showers: Slight", "05d"),
            new WeatherCodeInfo(81, "Rain showers: Moderate", "05d"),
            new WeatherCodeInfo(82, "Rain showers: Violent", "05d"),
            new WeatherCodeInfo(85, "Snow showers Slight", "08d"),
            new WeatherCodeInfo(86, "Snow showers Heavy,", "08d"),
            new WeatherCodeInfo(95, "Thunderstorm: Slight or moderate", "06d"),
            new WeatherCodeInfo(96, "Thunderstorm with slight and heavy hail", "06d"),
            new WeatherCodeInfo(99, "Thunderstorm with slight and heavy hail", "06d"),
        };
    }
}

