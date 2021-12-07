using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class UniformGenerator : IRandomGenerator
    {
        Random Generator { get; set; }
        public UniformGenerator(Random generator)
        {
            Generator = generator;
        }
        public double Generate(double min,double max)
        {
            return min + Generator.NextDouble() * (max - min);
        }
    }
}
