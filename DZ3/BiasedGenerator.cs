using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class BiasedGenerator : IRandomGenerator
    {
        Random Generator { get; set; }
        public BiasedGenerator(Random generator)
        {
            Generator = generator;
        }
        public double Generate(double min, double max)
        {
            int i = Generator.Next(1, 4);   //ako je slučajno generiran broj 1, onda će broj biti u gornjoj polovici, a ako je 2 ili 3, onda će biti u donjoj polovici
            if (i == 1)
            {
                return (min + max) / 2 + Generator.NextDouble() * (max - ((min + max) / 2));
            }
            else
            {
                return min + Generator.NextDouble() * (((min + max) / 2) - min);
            }
        }
    }
}
