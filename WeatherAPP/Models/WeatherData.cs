namespace WeatherAPP.Models
{
    public class WeatherData
    {
        public Timelines Timelines { get; set; }
    }

    public class Timelines
    {
        public List<MinutelyData> Minutely { get; set; }
    }

    public class MinutelyData
    {
        public DateTime Time { get; set; }
        public Values Values { get; set; }
    }

    public class Values
    {
        public double CloudBase { get; set; }
        public double? CloudCeiling { get; set; } // nullable because it can be null
        public double CloudCover { get; set; }
        public double DewPoint { get; set; }
        public double FreezingRainIntensity { get; set; }
        public double Humidity { get; set; }
        public double PrecipitationProbability { get; set; }
        public double PressureSurfaceLevel { get; set; }
        public double RainIntensity { get; set; }
        public double SleetIntensity { get; set; }
        public double SnowIntensity { get; set; }
        public double Temperature { get; set; }
        public double TemperatureApparent { get; set; }
        public double UvHealthConcern { get; set; }
        public double UvIndex { get; set; }
        public double Visibility { get; set; }
        public double WeatherCode { get; set; }
        public double WindDirection { get; set; }
        public double WindGust { get; set; }
        public double WindSpeed { get; set; }
    }

}
