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
    public partial class CarOverview : Form
    {
        public List<Car> ListOfCars;
        public List<Car> ListOfFilteredCars;


        public CarOverview(List<Car> cars)
        {
            InitializeComponent();
            ListOfCars = cars;
            ShowList();

        }

        public void ShowList()
        {
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

                    // add them to the list.
                    listViewCar.Items.Add(carlist);

                }
            }
            else
            {
                foreach (Car car in ListOfCars)
                {

                    ListViewItem carlist = new ListViewItem();

                    // setup the data for a list.
                    carlist.Text = (car.LicensePlate);
                    carlist.SubItems.Add(car.Brand);
                    carlist.SubItems.Add(car.Model);
                    carlist.SubItems.Add(car.Color);

                    // add them to the list.
                    listViewCar.Items.Add(carlist);

                }
            }
        }



        private void EditCarClick(object sender, EventArgs e)
        {
            
            if (ListOfCars.Count != 0)
            {
                DisableButtons();

                // launche the edit form.
                CarEditForm carEditForm = new CarEditForm(ListOfCars[listViewCar.SelectedIndices[0]]);
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
            if (ListOfCars.Count != 0)
            {
                if (listViewCar.Items[listViewCar.SelectedIndices[0]].Selected)
                {
                    ListOfCars.RemoveAt(listViewCar.SelectedIndices[0]);
                    ShowList();
                }
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


        private void SortColor(object sender, EventArgs e)
        {
            DisableButtons();

            using (var formfilter = new CarFilterForm(ListOfCars))
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

        private void Button_Reset_Filter_Click(object sender, EventArgs e)
        {
            ListOfFilteredCars = null;
            ShowList();
        }
    }
}
