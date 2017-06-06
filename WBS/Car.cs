using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBS
{
   public class Car
    {
       
        public GPSCoordinates GpsLocation { get; set; }
        
        public string Color { get; set; }
        public int Wheels { get; set; }
        public int LeftOrRightHand { get; set; }
        public int Seats { get; set; }
        public string Drivetrain { get; set; }
        public int BHP { get; set; }
        public int ApkDate { get; set; }
        public string LicensePlate { get; set; }
        public int ManufacturingDate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Catagory { get; set; }
        public string FuelType { get; set; }
        public int Mileage { get; set; }


        public Car(
            string color = null, 
            int wheels = 0, 
            int seats = 0, 
            string drivetrain = null, 
            int bhp = 0, 
            int apkDate = 0 , 
            string license = null, 
            int manufacturingDate = 0,
            string brand = null, 
            string model = null, 
            string catagory = null, 
            string fueltype = null,
            int mileage = 0,
            int steeringWheel = 0
            )
        {
            Color = color;
            Wheels = wheels;
            Seats = seats;
            Drivetrain = drivetrain;
            BHP = bhp;
            ApkDate = apkDate;
            LicensePlate = license;
            ManufacturingDate = manufacturingDate;
            Brand = brand;
            Model = model;
            Catagory = catagory;
            FuelType = fueltype;
            Mileage = mileage;
            LeftOrRightHand = steeringWheel;

            GetRandomGPSLocation(); // set GpsLocation to the random Gps location.
            
        }


        public string SteeringWheelOrientation()
        {
            if (LeftOrRightHand == 1)
            {
                return "right";
            }

            return "left";

        }

        public string CheckApk(int date)
        {
            if (ManufacturingDate >= (date -4))
            {
                return "Valid";
            }
            else
            {
                if (ApkDate >= date)
                {
                    return "Valid";
                }
            }
            //MessageBox.Show("Your APK date has expired!", "Error");
            return "Expired";

        }

        public void GetGPSLocation (double latitude, double longitude)
        {
            GpsLocation.Latitude = latitude;
            GpsLocation.Longitude = longitude;
            
        }

        public void GetRandomGPSLocation()
        {
            Random RandomGPS = new Random();
            double latitude = RandomGPS.NextDouble() * (53.414239 - 50.734500) + 50.734500;
            double longitude = RandomGPS.NextDouble() * (6.047974 - 4.608433) + 4.608433;
            GpsLocation = new GPSCoordinates(latitude, longitude);

        }

    }
}
