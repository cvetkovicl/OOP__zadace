using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class WeeklyForecast
    {
        public DailyForecast[] DailyForecasts { get; set; }
        public WeeklyForecast(DailyForecast[] dailyForecasts)
        {
            DailyForecasts = dailyForecasts;
        }
        public DailyForecast this[int ind]
        {
            get { return DailyForecasts[ind]; }
            set { DailyForecasts[ind] = value; }
        }
        public double GetMaxTemperature()
        {
            DailyForecast max = DailyForecasts[0];
            for(int i = 1; i < 7; i++)
            {
                if (DailyForecasts[i] > max) {
                    max = DailyForecasts[i];
                }
            }
            return max.Weather.GetTemperature();
        }
        public override string ToString()
        {
            string str = DailyForecasts[0].ToString();
            for (int i = 1; i < 7; i++)
            {
                str += '\n' + DailyForecasts[i].ToString();
            }
            return str + '\n';
        }
    }
}
