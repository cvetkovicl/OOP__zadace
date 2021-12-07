using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class WeatherGenerator
    {
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
        public double MinHumidity { get; set; }
        public double MaxHumidity { get; set; }
        public double MinWindSpeed { get; set; }
        public double MaxWindSpeed { get; set; }
        public IRandomGenerator randomGenerator;
        public WeatherGenerator(double minTemperature, double maxTemperature, double minHumidity, double maxHumidity, double minWindSpeed, double maxWindSpeed, IRandomGenerator randomGenerator)
        {
            MinTemperature = minTemperature;
            MaxTemperature = maxTemperature;
            MinHumidity = minHumidity;
            MaxHumidity = maxHumidity;
            MinWindSpeed = minWindSpeed;
            MaxWindSpeed = maxWindSpeed;
            this.randomGenerator = randomGenerator;
        }
        public void SetGenerator(IRandomGenerator randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }
        public Weather Generate()
        {
            Weather weather = new Weather();
            weather.SetTemperature(randomGenerator.Generate(MinTemperature, MaxTemperature));
            weather.SetHumidity(randomGenerator.Generate(MinHumidity, MaxHumidity));
            weather.SetWindSpeed(randomGenerator.Generate(MinWindSpeed, MaxWindSpeed));
            return weather;
        }
    }
}
