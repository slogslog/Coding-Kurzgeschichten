using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Globalization;

namespace GetGeoCoordsFromName
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en");

            WebClient webclient = new WebClient();

            const string folder = @"..\..\..\..\Daten";
            string fileWithNames = Path.Combine(folder, "Route_Locations.txt");
            string outputFile = Path.Combine(folder, "Route_Coordinates.txt");

            StreamReader reader = new StreamReader(fileWithNames);
            StreamWriter writer = new StreamWriter(outputFile, false);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');
                string name = line; // english and possibly the german name of the location
                if (parts.Length == 1)
                    name += ",";

                string locationEnglish = parts[0];
                string urlWikipedia = "https://en.wikipedia.org/wiki/" + locationEnglish;
                string downloaded = "";
                try
                {
                    downloaded = webclient.DownloadString(urlWikipedia);
                }
                catch (WebException)
                {
                    Console.WriteLine($"Download failed for {locationEnglish}.");
                    writer.WriteLine(line + ", Download failed");
                    continue;
                }

                // search for the coordinates in the string
                // "wgCoordinates":{"lat":51.2738,"lon":0.5789}
                const string lat = @"""lat"":"; // "lat"
                const string lon = @"""lon"":"; // "lon"
                double latitude = 0d, longitude = 0d;

                int posLat = downloaded.IndexOf(lat);
                if (posLat != -1)
                {
                    // "wgCoordinates":{"lat":51.2738,"lon":0.5789}
                    //                  ^     ^      ^
                    //                  |     |     posLatKomma
                    //             posLat posLatNumber
                    int posLatNumber = posLat + lat.Length;
                    int posLatKomma = downloaded.IndexOf(',', posLatNumber);
                    latitude = double.Parse(
                        downloaded.Substring(posLatNumber, posLatKomma - posLatNumber));

                    int posLon = downloaded.IndexOf(lon);
                    if (posLon != -1)
                    {
                        // "wgCoordinates":{"lat":51.2738,"lon":0.5789}
                        //                                ^     ^     ^
                        //                                |     |     posLonCurlyBracket
                        //                             posLon posLonNumber
                        int posLonNumber = posLon + lon.Length;
                        int posLonCurlyBracket = downloaded.IndexOf('}', posLonNumber);
                        longitude = double.Parse(
                            downloaded.Substring(posLonNumber, posLonCurlyBracket - posLonNumber));

                        string s = String.Format($"{line},{latitude},{longitude}");
                        writer.WriteLine(s);
                        Console.WriteLine($"Successfully added: {s}");
                        continue;
                    }
                }

                Console.WriteLine("No coordinates found for: " + line);
                writer.WriteLine(line + ",no coordinates found");
            }

            reader.Close();
            writer.Close();

            Console.WriteLine("Press a key to open the generated file.");
            Console.ReadKey();

            System.Diagnostics.Process.Start(outputFile);
        }
    }
}
