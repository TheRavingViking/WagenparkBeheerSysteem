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
    public partial class PersonFilterForm : Form
    {
        public List<Person> ListOfPersons;
        public List<Person> ListOfFilteredPersons;


        public PersonFilterForm(List<Person> listOfPersons)
        {
            InitializeComponent();
            this.ListOfPersons = listOfPersons;
        }

        public void QueryAll()
        {
            var cars = from listofperson in ListOfPersons
                       where (listofperson.FirstName == "" || listofperson.FirstName == TextBox_All_License.Text)
                       && (listofperson.LastName == "" || listofperson.LastName == TextBox_All_Brand.Text)
                       && (listofperson.Gender == "" || listofperson.Gender == ComboBox_Gender.Text)
                       select listofperson;

            ListOfFilteredPersons = cars.ToList();

        }

        public void QueryFirstName()
        {
            var person = from listofperson in ListOfPersons
                       where listofperson.FirstName == TextBox_Firstname.Text
                       select listofperson;

            ListOfFilteredPersons = person.ToList();

        }

        public void QueryLicenseExpiry()
        {
            var person = from listofperson in ListOfPersons
                         where listofperson.CheckLicense() == comboBox_License_expriy.Text
                         select listofperson;

            ListOfFilteredPersons = person.ToList();

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

        private void FilterFirstnameButton_Click(object sender, EventArgs e)
        {
            QueryFirstName();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FilterLicenseExpiryButton_Click(object sender, EventArgs e)
        {
            QueryLicenseExpiry();
            this.DialogResult = DialogResult.OK;
            Close();
        }


        // Disable the keyPress on the dropdown.
        private void ComboBox_Key_Press(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
