using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        public string filename;
        public FilePrinter(string filename)
        {
            this.filename = filename;
        }
        public void SetFilename(string filename)
        {
            this.filename = filename;
        }
        public void Print(Weather[] weathers)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Weather weather in weathers)
                {
                    writer.WriteLine(weather.ToString());
                }
            }
        }
    }
}
