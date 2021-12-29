using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ClassLibrary
{
    public class DailyForecastRepository : IEnumerable
    {
        private List<DailyForecast> forecasts;
        public void Add(DailyForecast forecast)
        {
            int f = 0;
            for(int i = 0; i < forecasts.Count; i++)
            {
                if (forecast.DayInWeek.Date == forecasts[i].DayInWeek.Date)
                {
                    forecasts[i] = forecast;
                    f = 1;
                    break;
                }
            }
            if (f == 0)
                forecasts.Add(forecast);
            forecasts.Sort((x, y) => x.DayInWeek.CompareTo(y.DayInWeek));
        }
        public void Add(List<DailyForecast> forecasts)
        {
            int f = 0;
            for(int i = 0; i < forecasts.Count; i++)
            {
                for(int j = 0; j < this.forecasts.Count; j++)
                {
                    if (forecasts[i].DayInWeek.Date == this.forecasts[j].DayInWeek.Date)
                    {
                        this.forecasts[j] = forecasts[i];
                        f = 1;
                        break;
                    }
                }
                if (f == 0)
                    this.forecasts.Add(forecasts[i]);
                f = 0;
            }
            this.forecasts.Sort((x, y) => x.DayInWeek.CompareTo(y.DayInWeek));
        }
        public void Remove(DateTime dateTime)
        {
            int f = 0;
            for(int i = 0; i < forecasts.Count; i++)
            {
                if (forecasts[i].DayInWeek.Date == dateTime.Date)
                {
                    forecasts.Remove(forecasts[i]);
                    f = 1;
                    break;
                }
            }
            if (f == 0)
            {
                throw new NoSuchDailyWeatherException($"No daily forecast for {dateTime.ToString()}");
            }
        }
        public IEnumerator GetEnumerator()
        {
            return forecasts.GetEnumerator();
        }
        public DailyForecastRepository()
        {
            forecasts = new List<DailyForecast>();
        }
        public DailyForecastRepository(DailyForecastRepository other) : this()
        {
            foreach (DailyForecast forecast in other.forecasts)
            {
                DailyForecast copy = new DailyForecast(forecast.DayInWeek, forecast.Weather);
                this.forecasts.Add(copy);
            }
        }
        public override string ToString()
        {
            return string.Join("\n", forecasts);
        }
    }
}
