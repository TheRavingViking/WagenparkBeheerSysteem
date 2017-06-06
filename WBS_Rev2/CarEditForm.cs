using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace WBS_Rev2
{
    public partial class CarEditForm : Form
    {
        private Car _car;

        public CarEditForm(Car car)
        {
            InitializeComponent();

            _car = car;
            textBox_color.Text = _car.Color;
            NM_Wheels.Text = _car.Wheels.ToString();
            textBox_seats.Text = _car.Seats.ToString();
            textBox_drivetrain.Text = _car.Drivetrain;
            textBox_BHP.Text = _car.BHP.ToString();
            textBox_ApkDate.Text = _car.ApkDate.ToString();
            textBox_license.Text = _car.LicensePlate;
            textBox_manufacturingDate.Text = _car.ManufacturingDate.ToString();
            textBox_brand.Text = _car.Brand;
            textBox_model.Text = _car.Model;
            textBox_catagory.Text = _car.Catagory;
            textBox_fuel.Text = _car.FuelType;
            if (_car.GpsID != null)
            {
                textBox_Latitude.Text = _car.GPSCoordinate.Latitude.ToString();
                textBox_Longitude.Text = _car.GPSCoordinate.Longitude.ToString();
            }
            else
            {
                Random RandomGPS = new Random();
                double latitude = Math.Round(RandomGPS.NextDouble() * (53.414239 - 50.734500) + 50.734500, 7);
                double longitude = Math.Round(RandomGPS.NextDouble() * (6.047974 - 4.608433) + 4.608433, 7);

                textBox_Latitude.Text = latitude.ToString();
                textBox_Longitude.Text = longitude.ToString();
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
            _car.Wheels = Int32.Parse(NM_Wheels.Text);
            _car.Seats = Int32.Parse(textBox_seats.Text);
            _car.Drivetrain = textBox_drivetrain.Text;
            _car.BHP = Int32.Parse(textBox_BHP.Text);
            _car.ApkDate = textBox_ApkDate.Value.Date;
            _car.LicensePlate = textBox_license.Text;
            _car.ManufacturingDate = textBox_manufacturingDate.Value.Date;
            _car.Brand = textBox_brand.Text;
            _car.Model = textBox_model.Text;
            _car.Catagory = textBox_catagory.Text;
            _car.FuelType = textBox_fuel.Text;
            _car.Mileage = Int32.Parse(textBox_mileage.Text);
            _car.LeftOrRightHand = CheckSteeringwheel();


            if (listViewPerson.SelectedItems.Count > 0)
            {
                int PersonID = Int32.Parse(listViewPerson.SelectedItems[0].Name);
                Person selectedPerson = Program.db.Persons.Find(PersonID);

                _car.Person = selectedPerson;
            }



            if (_car.GpsID == null)
            {
                GPSCoordinate _gps = new GPSCoordinate();
                Program.db.GPSCoordinates.Add(_gps);
                GPSCoordinate selectedGPS = Program.db.GPSCoordinates.Find(_gps.ID);
                _car.GPSCoordinate = selectedGPS;

            }
            _car.GPSCoordinate.Latitude = double.Parse(textBox_Latitude.Text);
            _car.GPSCoordinate.Longitude = double.Parse(textBox_Longitude.Text);
            
            // add fleetID to car
            _car.FleetID = Fleet.selectedID;


            //save car changes'
            Program.db.Cars.AddOrUpdate(_car);
            Program.db.SaveChanges();

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


                if (_car.GpsID != null)
                {
                    //update
                    GPSCoordinate CurrentGPS = Program.db.GPSCoordinates.Find(_car.GpsID);
                    // _car.GPSCoordinate = CurrentGPS;
                    CurrentGPS.Latitude = Double.Parse(textBox_Latitude.Text);
                    CurrentGPS.Longitude = Double.Parse(textBox_Longitude.Text);

                    Program.db.SaveChanges();
                }



            }


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
            System.Diagnostics.Process.Start("http://maps.google.com/?q=" + textBox_Latitude.Text.Replace(",", ".") + ',' + textBox_Longitude.Text.Replace(",", "."));
        }





        private void CarEditForm_Load(object sender, EventArgs e)
        {
            string gender = "";

            foreach (Person person in Program.db.Persons)
            {
                ListViewItem personlist = new ListViewItem();

                personlist.Text = (person.FirstName);
                personlist.SubItems.Add(person.LastName);
                personlist.Name = person.ID.ToString();

                // add them to the list.
                listViewPerson.Items.Add(personlist);
            }

            if (_car.Person != null)
            {
                if (_car.Person.Gender == 0)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }

                Label_CurrentOwnerInfo.Text = "Name: " + _car.Person.FirstName + " " + _car.Person.LastName + "\n Gender: " + gender + "\n Birthdate: " + _car.Person.Birthday.Value.ToShortDateString() + "\n Drivers license: " + _car.Person.DriversLicense + "\n Date Of Expiry: " + _car.Person.DateOfExpiry;

            }
            else
            {
                Label_CurrentOwnerInfo.Text = "No owner yet";
            }

        }

        private void textBox_personName_KeyDown(object sender, KeyEventArgs e)
        {
            listViewPerson.Items.Clear();

            string searchTerm = textBox_personName.Text;

            var persons = from person in Program.db.Persons
                          where person.FirstName.Contains(searchTerm) || person.LastName.Contains(searchTerm)
                          select person;

            foreach (Person person in persons)
            {
                ListViewItem personlist = new ListViewItem();

                personlist.Text = (person.FirstName);
                personlist.SubItems.Add(person.LastName);
                personlist.Name = person.ID.ToString();

                // add them to the list.
                listViewPerson.Items.Add(personlist);
            }
        }
    }
}

