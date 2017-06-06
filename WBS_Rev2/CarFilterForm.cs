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
    public partial class CarFilterForm : Form
    {
        public List<Car> ListOfFilteredCars;
        public List<Car> ListOfFleetCars;

        public CarFilterForm()
        {
            InitializeComponent();

            var cars = from listOfCar in Program.db.Cars
                       where listOfCar.FleetID == Fleet.selectedID
                       select listOfCar;

            ListOfFleetCars = cars.ToList();
        }

        public void QueryAll()
        {
            var carsList = from car in ListOfFleetCars
                       where (car.LicensePlate.Contains(TextBox_All_License.Text) && TextBox_All_License.Text != "")
                       || (car.Brand.Contains(TextBox_All_Brand.Text) && TextBox_All_Brand.Text != "")
                       || (car.Model.Contains(TextBox_All_Model.Text) && TextBox_All_Model.Text != "")
                       || (car.Color.Contains(TextBox_All_Color.Text) && TextBox_All_Color.Text != "")
                           select car;

            ListOfFilteredCars = carsList.ToList();
           
        }

        public void QueryColor()
        {
            var carsList = from car in ListOfFleetCars
                       where car.Color == TextBoxColor.Text

                       select car;

            ListOfFilteredCars = carsList.ToList();

        }

        public void QueryAPKValid()
        {

            var carsList = from car in ListOfFleetCars
                       where car.CheckApk() == comboBox_Apk_Date.Text
                       select car;

            ListOfFilteredCars = carsList.ToList();

        }


        private void ReturnToList_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Sort_All_Click(object sender, EventArgs e)
        {
            QueryAll();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FilterColorButton_Click(object sender, EventArgs e)
        {
            QueryColor();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void Button_Filter_Apk_Click(object sender, EventArgs e)
        {
            QueryAPKValid();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        // Disable the keyPress on the dropdown.
        private void ComboBox_APK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
