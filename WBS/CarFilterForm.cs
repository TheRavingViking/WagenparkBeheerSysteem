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
    public partial class CarFilterForm : Form
    {

        public List<Car> ListOfCars;
        public List<Car> ListOfFilteredCars;

        public CarFilterForm(List<Car> listOfCars)
        {
            InitializeComponent();
            this.ListOfCars = listOfCars;
        }

        public void QueryAll()
        {
            var cars = from listOfCar in ListOfCars
                       where (listOfCar.LicensePlate == "" || listOfCar.LicensePlate == TextBox_All_License.Text)
                       && (listOfCar.Brand == "" || listOfCar.Brand == TextBox_All_Brand.Text)
                       && (listOfCar.Model == "" || listOfCar.Model == TextBox_All_Model.Text)
                       && (listOfCar.Color == "" || listOfCar.Color == TextBox_All_Color.Text)
                       select listOfCar;

            ListOfFilteredCars = cars.ToList();
           
        }

        public void QueryColor()
        {
            var cars = from listOfCar in ListOfCars
                       where listOfCar.Color == TextBoxColor.Text
                       select listOfCar;

            ListOfFilteredCars = cars.ToList();

        }

        public void QueryAPKValid()
        {
            var cars = from listOfCar in ListOfCars
                       where listOfCar.CheckApk(DateTime.Now.Year) == comboBox_Apk_Date.Text
                       select listOfCar;

            ListOfFilteredCars = cars.ToList();

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
