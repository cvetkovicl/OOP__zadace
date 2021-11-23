using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class DailyForecast
    {
        public DateTime DayInWeek { get; set; }
        public Weather WeatherOnChosenDay { get; set; }
        public DailyForecast(DateTime dayInWeek,Weather weatherOnChosenDay)
        {
            DayInWeek = dayInWeek;
            WeatherOnChosenDay = weatherOnChosenDay;
        }
        public static bool operator >(DailyForecast forecast1, DailyForecast forecast2)
        {
            return forecast1.WeatherOnChosenDay.GetTemperature() > forecast2.WeatherOnChosenDay.GetTemperature();
        }
        public static bool operator <(DailyForecast forecast1, DailyForecast forecast2)
        {
            return forecast1.WeatherOnChosenDay.GetTemperature() < forecast2.WeatherOnChosenDay.GetTemperature();
        }
        public string GetAsString()
        {
            return $"{DayInWeek.ToString()}: T={WeatherOnChosenDay.GetTemperature()}°C, w={WeatherOnChosenDay.GetWindSpeed()}km/h, h={WeatherOnChosenDay.GetHumidity()}%";
        }
    }
}
