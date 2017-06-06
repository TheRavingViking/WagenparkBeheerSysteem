using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBS
{
    public partial class CarEditForm : Form
    {
        private Car _car;

        public CarEditForm(Car car)
        {
            InitializeComponent();

            _car = car;

            textBox_color.Text = _car.Color;
            textBox_wheels.Text = _car.Wheels.ToString();
            textBox_seats.Text = _car.Seats.ToString();
            textBox_drivetrain.Text = _car.Drivetrain;
            textBox_BHP.Text = _car.BHP.ToString();
            textBox_ApkDate.Text = _car.ApkDate.ToString();  // year
            textBox_license.Text = _car.LicensePlate;
            textBox_manufacturingDate.Text = _car.ManufacturingDate.ToString();
            textBox_brand.Text = _car.Brand;
            textBox_model.Text = _car.Model;
            textBox_catagory.Text = _car.Catagory;
            textBox_fuel.Text = _car.FuelType;
            if (_car.GpsLocation != null)
            {
                textBox_Latitude.Text = _car.GpsLocation.Latitude.ToString();
                textBox_Longitude.Text = _car.GpsLocation.Longitude.ToString();
            }
            else
            {
                textBox_Latitude.Text = "NO GPS";
                textBox_Longitude.Text = "NO GPS";
            }
            textBox_mileage.Text = _car.Mileage.ToString();

            if (_car.LeftOrRightHand == 1)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
                   
  
        }

        private void SaveCloseClick(object sender, EventArgs e)
        {
            _car.Color = textBox_color.Text;
            _car.Wheels = Int32.Parse(textBox_wheels.Text);
            _car.Seats = Int32.Parse(textBox_seats.Text);
            _car.Drivetrain = textBox_drivetrain.Text;
            _car.BHP = Int32.Parse(textBox_BHP.Text);
            _car.ApkDate = Int32.Parse(textBox_ApkDate.Text);  // year
            _car.LicensePlate = textBox_license.Text;
            _car.ManufacturingDate = Int32.Parse(textBox_manufacturingDate.Text);
            _car.Brand = textBox_brand.Text;
            _car.Model = textBox_model.Text;
            _car.Catagory = textBox_catagory.Text;
            _car.FuelType = textBox_fuel.Text;
            _car.Mileage = Int32.Parse(textBox_mileage.Text);
            _car.LeftOrRightHand = CheckSteeringwheel();
            _car.GpsLocation.Latitude = Double.Parse(textBox_Latitude.Text);
            _car.GpsLocation.Longitude = Double.Parse(textBox_Longitude.Text);

            //close the form();
            Close();

        }

        public int CheckSteeringwheel()
        {
            if (radioButton2.Checked == true)
            {
                return 1;
            }
            return 0;
        }

        private void button_update_gps_Click(object sender, EventArgs e)
        {

            if (button_update_gps.Text == "Edit")
            {
                textBox_Latitude.Enabled = true;
                textBox_Longitude.Enabled = true;

                button_show_on_map.Enabled = false;
                button_update_gps.Text = "Update";
            }
            else
            {
                textBox_Latitude.Enabled = false;
                textBox_Longitude.Enabled = false;

                button_show_on_map.Enabled = true;
                button_update_gps.Text = "Edit";
            }


            _car.GetGPSLocation(Double.Parse(textBox_Latitude.Text), Double.Parse(textBox_Longitude.Text));


            textBox_Latitude.Text = _car.GpsLocation.Latitude.ToString();
            textBox_Longitude.Text = _car.GpsLocation.Longitude.ToString();


        }


        private void coords_double(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button_show_on_map_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://maps.google.com/?q=" + _car.GpsLocation.LatitudeToString() + ',' + _car.GpsLocation.LongitudeToString());
        }



    }
}
