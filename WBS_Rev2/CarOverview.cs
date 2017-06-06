using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBS_Rev2
{
    public partial class CarOverview : Form
    {
        public List<Car> ListOfFilteredCars;
        public List<Car> FleetCars;

        public CarOverview()
        {
            InitializeComponent();
            ShowList();

        }

        public void ShowList()
        {
            var cars = from listOfCar in Program.db.Cars
                       where listOfCar.FleetID == Fleet.selectedID
                       select listOfCar;

            FleetCars = cars.ToList();


            listViewCar.Items.Clear();

            if (ListOfFilteredCars != null)
            {
                foreach (Car car in ListOfFilteredCars)
                {
                    ListViewItem carlist = new ListViewItem();

                    // setup the data for a list.
                    carlist.Text = (car.LicensePlate);
                    carlist.SubItems.Add(car.Brand);
                    carlist.SubItems.Add(car.Model);
                    carlist.SubItems.Add(car.Color);
                    carlist.Tag = car.ID;
                    // add them to the list.
                    listViewCar.Items.Add(carlist);

                }
            }
            else
            {
                foreach (Car car in FleetCars)
                {

                    ListViewItem carlist = new ListViewItem();

                    // setup the data for a list.
                    carlist.Text = (car.LicensePlate);
                    carlist.SubItems.Add(car.Brand);
                    carlist.SubItems.Add(car.Model);
                    carlist.SubItems.Add(car.Color);
                    carlist.Tag = car.ID;

                    // add them to the list.
                    listViewCar.Items.Add(carlist);

                }
            }
        }



        private void EditCarClick(object sender, EventArgs e)
        {
            // check if there is something selected
            if (listViewCar.SelectedItems.Count > 0)
            {
                DisableButtons();

                var CarID = listViewCar.SelectedItems[0].Tag;

                Car selectedCar = Program.db.Cars.Find(CarID);

                // launche the edit form.
                CarEditForm carEditForm = new CarEditForm(selectedCar);
                carEditForm.FormClosed += Reload_FormClosed;
                carEditForm.Show();
            }
        }


        private void ReturnToMainMenuFromCarList_Click(object sender, EventArgs e)
        {
            // close the form.
            Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // check if there is something selected
            if (listViewCar.SelectedItems.Count > 0)
            {
                var CarID = listViewCar.SelectedItems[0].Tag;

                Car selectedCar = Program.db.Cars.Find(CarID);

                GPSCoordinate gpsFromSelectedCar = Program.db.GPSCoordinates.Find(selectedCar.GpsID);

                Program.db.GPSCoordinates.Remove(gpsFromSelectedCar);
                Program.db.Cars.Remove(selectedCar);
                Program.db.SaveChanges();
                ListOfFilteredCars = null;
                ShowList();
            }       
        }

        private void Reload_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnableButtons();
            ShowList();
        }

        private void EnableButtons()
        {
            Button_Return_To_Main_Menu.Enabled = true;
            Button_Edit_Car.Enabled = true;
            Button_Delete_Car.Enabled = true;
            Button_Filter_Car.Enabled = true;
            Button_Filter_Car.Enabled = true;
            Button_Reset_Filter.Enabled = true;
        }

        private void DisableButtons()
        {
            Button_Return_To_Main_Menu.Enabled = false;
            Button_Edit_Car.Enabled = false;
            Button_Delete_Car.Enabled = false;
            Button_Filter_Car.Enabled = false;
            Button_Filter_Car.Enabled = false;
            Button_Reset_Filter.Enabled = false;
        }


        private void Button_Reset_Filter_Click(object sender, EventArgs e)
        {
            ListOfFilteredCars = null;
            ShowList();
        }

        private void FilterCar(object sender, EventArgs e)
        {
            DisableButtons();

            using (var formfilter = new CarFilterForm())
            {
                var result = formfilter.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ListOfFilteredCars = formfilter.ListOfFilteredCars;
                    ShowList();

                }
            }
            EnableButtons();
        }
    }
}
