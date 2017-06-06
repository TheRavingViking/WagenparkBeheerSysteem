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
    public partial class WbsMainForm : Form
    {
        public List<Car> listCars = new List<Car>();
        public List<Person> listPerson = new List<Person>();

        public WbsMainForm()
        {
            InitializeComponent();
            
        }

        // Car list
        private void CarListClick(object sender, EventArgs e)
        {
            DisableButtons();

            CarOverview car = new CarOverview(listCars);
            car.FormClosed += EnableButtons_FormClosed;
            car.Show();
        }

        // Person List
        private void PersonListClick(object sender, EventArgs e)
        {
            DisableButtons();

            PersonOverview person = new PersonOverview(listPerson);
            person.FormClosed += EnableButtons_FormClosed;
            person.Show();
        }

        // Create car
        private void AddCarButtonClick(object sender, EventArgs e)
        {
            DisableButtons();

            listCars.Add(new Car());
            CarEditForm carEditForm = new CarEditForm(listCars[listCars.Count -1]);
            carEditForm.FormClosed += EnableButtons_FormClosed;
            carEditForm.Show();
        }

        // create Person 
        private void AddPersonButtonClick(object sender, EventArgs e)
        {
            DisableButtons();

            listPerson.Add(new Person());
            PersonEditForm personEditForm = new PersonEditForm(listPerson[listPerson.Count - 1]);
            personEditForm.FormClosed += EnableButtons_FormClosed;
            personEditForm.Show();
        }

        private void EnableButtons_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnableButtons();
        }

        private void EnableButtons()
        {
            Button_Car_List.Enabled = true;
            Button_Person_List.Enabled = true;
            Button_Add_Car.Enabled = true;
            Button_Add_Person.Enabled = true;
        }

        private void DisableButtons()
        {
            Button_Car_List.Enabled = false;
            Button_Person_List.Enabled = false;
            Button_Add_Car.Enabled = false;
            Button_Add_Person.Enabled = false;
        }
    }
}
