namespace WeatherForecast.Models
{

    // Disse klassene er laget ved å bruke Visual Studio funksjonen paste as json, men en json respons jeg fikk fra postman.


    public class WeatherForecastDaily
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Weather current_weather { get; set; }
        public Daily_Units daily_units { get; set; }
        public Daily daily { get; set; }
    }

   

    public class Daily_Units
    {
        public string time { get; set; }
        public string temperature_2m_max { get; set; }
        public string temperature_2m_min { get; set; }
    }

    public class Daily
    {
        public string[] time { get; set; }
        public float[] temperature_2m_max { get; set; }
        public float[] temperature_2m_min { get; set; }
    }

}
