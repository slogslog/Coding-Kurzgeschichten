using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace ListOfCities
{
    class City
    {   
        // Data
        public string Name { get; private set; }
        public GeoCoordinate Location { get; private set; }

        // ctor (Konstruktor)
        // latitude = geographische Breite, z. B. Vienna 48.2083°
        // longitude = geographische Länge, z. B. Vienna 16.3731°
        public City( string name, double latitude, double longitude )
        {
            Name = name;
            Location = new GeoCoordinate(latitude, longitude);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

