using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ConsolePrinter : IPrinter
    {
        public ConsoleColor consoleColor;
        public ConsolePrinter(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
        }
        public void SetConsoleColor(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
        }

        public void Print(Weather[] weathers)
        {
            Console.ForegroundColor = consoleColor;
            foreach (Weather weather in weathers)
            {
                Console.WriteLine(weather.ToString(), consoleColor);
            }
        }
    }
}
