using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class DailyForecast
    {
        public DateTime DayInWeek { get; set; }
        public Weather Weather { get; set; }
        public DailyForecast(DateTime dayInWeek,Weather weather)
        {
            DayInWeek = dayInWeek;
            Weather = weather;
        }
        public static bool operator >(DailyForecast forecast1, DailyForecast forecast2)
        {
            return forecast1.Weather.GetTemperature() > forecast2.Weather.GetTemperature();
        }
        public static bool operator <(DailyForecast forecast1, DailyForecast forecast2)
        {
            return forecast1.Weather.GetTemperature() < forecast2.Weather.GetTemperature();
        }
        public override string ToString()
        {
            return $"{DayInWeek.ToString()}: T={Weather.GetTemperature()}°C, w={Weather.GetWindSpeed()}km/h, h={Weather.GetHumidity()}%";
        }
    }
}
