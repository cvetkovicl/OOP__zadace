using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public static class ForecastUtilities
    {
        public static DailyForecast Parse(string forecast)
        {
            string time = forecast.Substring(0, 19);
            string temperature = forecast.Substring(20, 4);
            string windSpeed = forecast.Substring(25, 5);
            string humidity = forecast.Substring(31, 3);
            return new DailyForecast(DateTime.Parse(time), new Weather(double.Parse(temperature) / 100, double.Parse(humidity) / 10, double.Parse(windSpeed) / 100));
        }
        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            double max = weathers[0].CalculateWindChill();
            int ind = 0;
            for (int i = 1; i < weathers.Length; i++)
            {
                if (weathers[i].CalculateWindChill() > max)
                {
                    max = weathers[i].CalculateWindChill();
                    ind = i;
                }
            }
            return weathers[ind];
        }
        public static void PrintWeathers(IPrinter[] printers, Weather[] weathers)
        {
            foreach(IPrinter printer in printers)
            {
                printer.Print(weathers);
            }
        }
    }
}
