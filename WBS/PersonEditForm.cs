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
    public partial class PersonEditForm : Form
    {
        private Person _person;

        public PersonEditForm(Person person)
        {
            InitializeComponent();

            _person = person;
            textBox_Firstname.Text = _person.FirstName;
            textBox_Lastname.Text = _person.LastName;
            if (_person.Gender == "Male")
            {
                radioButton_Male.Checked = true;
            }
            else
            {
                radioButton_Female.Checked = true;
            }
            dateTimePicker_Birthday.Text = _person.Birthday;
            textBox_Drivers_Licence.Text = _person.DriversLicense;
            dateTimePicker_Date_Of_Expire.Text = _person.DateOfExpiry;


        }


        public string Gender()
        {
            if (radioButton_Male.Checked == true)
            {
                return "Male";
            }
            return "Female";
        }


        private void SaveCloseClick(object sender, EventArgs e)
        {
            _person.FirstName = textBox_Firstname.Text;
            _person.LastName = textBox_Lastname.Text;
            _person.Birthday = dateTimePicker_Birthday.Text;
            _person.Gender = Gender();
            _person.DriversLicense = textBox_Drivers_Licence.Text;
            _person.DateOfExpiry = dateTimePicker_Date_Of_Expire.Text;


            Close();

        }
    }
}
