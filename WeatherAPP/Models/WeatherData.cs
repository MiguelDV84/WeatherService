﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherAPP.Models
{
    public class WeatherData
    {
        [JsonProperty("queryCost")]
        public int QueryCost { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("resolvedAddress")]
        public string ResolvedAddress { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("tzoffset")]
        public int TzOffset { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("days")]
        public List<WeatherDay> Days { get; set; }

        [JsonProperty("alerts")]
        public List<Alert> Alerts { get; set; }

        [JsonProperty("stations")]
        public Dictionary<string, WeatherStation> Stations { get; set; }

        [JsonProperty("currentConditions")]
        public CurrentConditions CurrentConditions { get; set; }
    }

    public class WeatherDay
    {
        [JsonProperty("datetime")]
        public string DateTime { get; set; }

        [JsonProperty("datetimeEpoch")]
        public long DateTimeEpoch { get; set; }

        [JsonProperty("tempmax")]
        public double TempMax { get; set; }

        [JsonProperty("tempmin")]
        public double TempMin { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feelslikemax")]
        public double FeelsLikeMax { get; set; }

        [JsonProperty("feelslikemin")]
        public double FeelsLikeMin { get; set; }

        [JsonProperty("feelslike")]
        public double FeelsLike { get; set; }

        [JsonProperty("dew")]
        public double Dew { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("precipprob")]
        public int PrecipProb { get; set; }

        [JsonProperty("precipcover")]
        public double PrecipCover { get; set; }

        [JsonProperty("preciptype")]
        public string PrecipType { get; set; }

        [JsonProperty("snow")]
        public double Snow { get; set; }

        [JsonProperty("snowdepth")]
        public double SnowDepth { get; set; }

        [JsonProperty("windgust")]
        public double WindGust { get; set; }

        [JsonProperty("windspeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("winddir")]
        public double WindDir { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("cloudcover")]
        public double CloudCover { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("solarradiation")]
        public double SolarRadiation { get; set; }

        [JsonProperty("solarenergy")]
        public double SolarEnergy { get; set; }

        [JsonProperty("uvindex")]
        public int UvIndex { get; set; }

        [JsonProperty("severerisk")]
        public int SevereRisk { get; set; }

        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunriseEpoch")]
        public long SunriseEpoch { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("sunsetEpoch")]
        public long SunsetEpoch { get; set; }

        [JsonProperty("moonphase")]
        public double MoonPhase { get; set; }

        [JsonProperty("conditions")]
        public string Conditions { get; set; }

        [JsonProperty("description")]
        public string DayDescription { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("stations")]
        public List<string> Stations { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("hours")]
        public List<WeatherHour> Hours { get; set; }
    }

    public class WeatherHour
    {
        [JsonProperty("datetime")]
        public string DateTime { get; set; }

        [JsonProperty("datetimeEpoch")]
        public long DateTimeEpoch { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feelslike")]
        public double FeelsLike { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("dew")]
        public double Dew { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("precipprob")]
        public int PrecipProb { get; set; }

        [JsonProperty("snow")]
        public double Snow { get; set; }

        [JsonProperty("snowdepth")]
        public double SnowDepth { get; set; }

        [JsonProperty("preciptype")]
        public string PrecipType { get; set; }

        [JsonProperty("windgust")]
        public double WindGust { get; set; }

        [JsonProperty("windspeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("winddir")]
        public double WindDir { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("cloudcover")]
        public double CloudCover { get; set; }

        [JsonProperty("solarradiation")]
        public double SolarRadiation { get; set; }

        [JsonProperty("solarenergy")]
        public double SolarEnergy { get; set; }

        [JsonProperty("uvindex")]
        public int UvIndex { get; set; }

        [JsonProperty("severerisk")]
        public int SevereRisk { get; set; }

        [JsonProperty("conditions")]
        public string Conditions { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("stations")]
        public object Stations { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class Alert
    {
        // Define properties of the alert if needed
    }

    public class WeatherStation
    {
        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("useCount")]
        public int UseCount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quality")]
        public int Quality { get; set; }

        [JsonProperty("contribution")]
        public int Contribution { get; set; }
    }

    public class CurrentConditions
    {
        [JsonProperty("datetime")]
        public string DateTime { get; set; }

        [JsonProperty("datetimeEpoch")]
        public long DateTimeEpoch { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feelslike")]
        public double FeelsLike { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("dew")]
        public double Dew { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("precipprob")]
        public int PrecipProb { get; set; }

        [JsonProperty("snow")]
        public double Snow { get; set; }

        [JsonProperty("snowdepth")]
        public double SnowDepth { get; set; }

        [JsonProperty("preciptype")]
        public string PrecipType { get; set; }

        [JsonProperty("windgust")]
        public double WindGust { get; set; }

        [JsonProperty("windspeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("winddir")]
        public double WindDir { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("cloudcover")]
        public double CloudCover { get; set; }

        [JsonProperty("solarradiation")]
        public double SolarRadiation { get; set; }

        [JsonProperty("solarenergy")]
        public double SolarEnergy { get; set; }

        [JsonProperty("uvindex")]
        public int UvIndex { get; set; }

        [JsonProperty("conditions")]
        public string Conditions { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("stations")]
        public List<string> Stations { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunriseEpoch")]
        public long SunriseEpoch { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("sunsetEpoch")]
        public long SunsetEpoch { get; set; }

        [JsonProperty("moonphase")]
        public double MoonPhase { get; set; }
    }
}
