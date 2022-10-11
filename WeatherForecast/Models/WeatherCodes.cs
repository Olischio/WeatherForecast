using System.Net;

namespace WeatherForecast.Models
{
    public static class WeatherCodes
    {


        public static List<KeyValuePair<int, string>> Weathercodes = new List<KeyValuePair<int, string>>
        {

        new KeyValuePair<int, string>(0,    "Clear sky"),
        new KeyValuePair<int, string>(1,"Mainly clear, partly cloudy, and overcast"),
        new KeyValuePair<int, string>(2,"Mainly clear, partly cloudy, and overcast"),
            new KeyValuePair<int, string>(3,    "Mainly clear, partly cloudy, and overcast"),
        new KeyValuePair<int, string>(45,  "Fog and depositing rime fog"),
        new KeyValuePair<int, string>(48,    "Fog and depositing rime fog"),

        new KeyValuePair<int, string>(51,   "Drizzle: Light intensity"),
        new KeyValuePair<int, string>(53,   "Drizzle: moderate intensity"),
        new KeyValuePair<int, string>(55 ,   "Drizzle: dense intensity"),

        new KeyValuePair<int, string>(56,     "Freezing Drizzle: Light and dense intensity"),
        new KeyValuePair<int, string>(57  ,  "Freezing Drizzle: Light and dense intensity"),


        new KeyValuePair<int, string>(61, "Rain: Slight, moderate and heavy intensity"),
        new KeyValuePair<int, string>(63,"Rain: Slight, moderate and heavy intensity"),
        new KeyValuePair<int, string>(65,    "Rain: Slight, moderate and heavy intensity"),

        new KeyValuePair<int, string>(66, " Freezing Rain: Light and heavy intensity"),
        new KeyValuePair<int, string>(67  , "Freezing Rain: Light and heavy intensity"),


        //new KeyValuePair<int, string>(71, 73, 75    Snow fall: Slight, moderate, and heavy intensity"),
        //new KeyValuePair<int, string>(71, 73, 75    Snow fall: Slight, moderate, and heavy intensity"),
        //new KeyValuePair<int, string>(71, 73, 75    Snow fall: Slight, moderate, and heavy intensity"),

        //new KeyValuePair<int, string>(77    Snow grains
        //new KeyValuePair<int, string>(80, 81, 82    Rain showers: Slight, moderate, and violent"),
        //new KeyValuePair<int, string>(80, 81, 82    Rain showers: Slight, moderate, and violent"),
        //new KeyValuePair<int, string>(80, 81, 82    Rain showers: Slight, moderate, and violent"),


        //new KeyValuePair<int, string>(85, 86    Snow showers slight and heavy"),
        //new KeyValuePair<int, string>(85, 86    Snow showers slight and heavy"),

        //new KeyValuePair<int, string>(95 *  Thunderstorm: Slight or moderate"),
        //new KeyValuePair<int, string>(96, 99 *  Thunderstorm with slight and heavy hail"),
        //new KeyValuePair<int, string>(96, 99 *  Thunderstorm with slight and heavy hail"),

            };
    }
}

