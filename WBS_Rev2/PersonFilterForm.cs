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
    public partial class PersonFilterForm : Form
    {

        public List<Person> ListOfFilteredPersons;


        public PersonFilterForm()
        {
            InitializeComponent();

            var cars = from listOfCar in Program.db.Cars
                       where listOfCar.FleetID == Fleet.selectedID
                       && listOfCar.OwnerID != null
                       select listOfCar.Person;

            ListOfFilteredPersons = cars.ToList();


        }

        public void QueryAll()
        {


            var personList = from person in ListOfFilteredPersons
                             where (person.FirstName.Contains(TextBox_All_License.Text) && TextBox_All_License.Text != "") 
                       || (person.LastName.Contains(TextBox_All_Brand.Text) && TextBox_All_Brand.Text != "")
                        select person;

            ListOfFilteredPersons = personList.ToList();

        }

        public void QueryFirstName()
        {
            var personList = from person in ListOfFilteredPersons
                             where person.FirstName.Contains(TextBox_Firstname.Text)
                       select person;

            ListOfFilteredPersons = personList.ToList();

        }

        //public void QueryLicenseExpiry()
        //{
        //    var person = from listofperson in _db.Persons
        //                 where listofperson.CheckLicense() == comboBox_License_expriy.Text
        //                 select listofperson;

        //    ListOfFilteredPersons = person.ToList();

        //}


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
            //QueryLicenseExpiry();
            //this.DialogResult = DialogResult.OK;
            //Close();

            MessageBox.Show("Payed subscription required for this function, Please contact your system administrator.", "Upgrade to Pro!");

            // Ps als je ons hiermee helpt dan is het gratis. Er moet een function aangeroepen worden binnen de linQ.

        }


        // Disable the keyPress on the dropdown.
        private void ComboBox_Key_Press(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public int Gender()
        {
            if (ComboBox_Gender.ValueMember == "Male")
            {
                return 1;
            }
            return 0;
        }


    }
}
