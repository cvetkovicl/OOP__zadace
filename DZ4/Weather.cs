using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Weather
    {
        private double t;
        private double r;
        private double w;
        private readonly double c1 = -8.78469475556;
        private readonly double c2 = 1.61139411;
        private readonly double c3 = 2.33854883889;
        private readonly double c4 = -0.14611605;
        private readonly double c5 = -0.012308094;
        private readonly double c6 = -0.0164248277778;
        private readonly double c7 = 0.002211732;
        private readonly double c8 = 0.00072546;
        private readonly double c9 = -0.000003582;
        public double GetTemperature() { return t; }
        public double GetHumidity() { return r; }
        public double GetWindSpeed() { return w; }
        public void SetTemperature(double temperature) { this.t = temperature; }
        public void SetHumidity(double humidity) { this.r = humidity; }
        public void SetWindSpeed(double windSpeed) { this.w = windSpeed; }
        public double CalculateFeelsLikeTemperature()
        {
            return c1 + c2 * t + c3 * r + c4 * t * r + c5 * t * t + c6 * r * r + c7 * t * t * r + c8 * t * r * r + c9 * t * t * r * r;
        }
        public double CalculateWindChill()
        {
            if (t <= 10.0 && w >= 3.0)
            {
                return 13.12 + 0.6215 * t - 11.37 * Math.Pow(w, 0.16) + 0.3965 * t * Math.Pow(w, 0.16);
            }
            else
            {
                return 0;
            }
        }
        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.t = temperature;
            this.r = humidity;
            this.w = windSpeed;
        }
        public Weather() { }
        public override string ToString()
        {
            return $"T={t}°C, w={w}km/h, h={r}%";
        }
    }
}
