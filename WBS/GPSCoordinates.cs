using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WBS
{
    public class GPSCoordinates
    {
        private double _latitude;
        private double _longitude;

        public double Latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                _latitude = Math.Round(value, 7);
            }
        }

        public double Longitude {
            get
            {
                return _longitude;
            }
            set
            {
                _longitude = Math.Round(value, 7);
            }
        }

    
        // set your own coords.
        public GPSCoordinates(
            double latitude,
            double longitude

            )
        {
            Latitude = latitude;
            Longitude = longitude;

        }

        // return a string from the latitude.
        public string LatitudeToString()
        {
            return Latitude.ToString().Replace(",", ".");
        }

        // return a string from the longitude.
        public string LongitudeToString()
        {
            return Longitude.ToString().Replace(",", ".");
        }





    }
}
