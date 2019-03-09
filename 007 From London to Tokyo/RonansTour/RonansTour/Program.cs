using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Device.Location;

namespace RonansTour
{
    class Program
    {
        static GeoCoordinate AnalyzeLine(string line, out string fulllocation)
        {
            string[] parts = line.Split(',');
            fulllocation = parts[0];
            if (parts[1].Length > 0)
                fulllocation += " (" + parts[1] + ")"; // english (german)

            double latitude = double.Parse(parts[2]);
            double longitude = double.Parse(parts[3]);
            return new GeoCoordinate(latitude, longitude);
        }

        static double ToKm(double value)
        {
            return Math.Round(value / 1000d, 0);
        }

        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en");

            double distance = 0;
            StreamReader reader = new StreamReader(@"..\..\..\..\Daten\Route_GeoCoords.txt");
            GeoCoordinate previous = AnalyzeLine(reader.ReadLine(), out string name);
            Console.WriteLine("Start@" + name);

            while (!reader.EndOfStream )
            {
                string line = reader.ReadLine();
                GeoCoordinate next = AnalyzeLine(line, out string locationname );
                double distBetweenLocations = next.GetDistanceTo(previous);
                distance += distBetweenLocations;
                Console.WriteLine($"{locationname,-20} {ToKm(distBetweenLocations),6}km {ToKm(distance),6}km");
                previous = next;
            }

            reader.Close();

            Console.ReadKey();
        }
    }
}
