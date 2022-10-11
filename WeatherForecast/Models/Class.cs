namespace WeatherForecast.Models
{



    public class WeatherForecast
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Weather current_weather { get; set; }
        public Hourly_Units hourly_units { get; set; }
        public Hourly hourly { get; set; }
    }

    public class Current_Weather
    {
        public float temperature { get; set; }
        public float windspeed { get; set; }
        public float winddirection { get; set; }
        public int weathercode { get; set; }
        public string time { get; set; }
    }

    public class Hourly_Units
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
        public string relativehumidity_2m { get; set; }
        public string rain { get; set; }
        public string windspeed_10m { get; set; }
    }

    public class Hourly
    {
        public string[] time { get; set; }
        public float[] temperature_2m { get; set; }
        public int[] relativehumidity_2m { get; set; }
        public float[] rain { get; set; }
        public float[] windspeed_10m { get; set; }
    }

}
