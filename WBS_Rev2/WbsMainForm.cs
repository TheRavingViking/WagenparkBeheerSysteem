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
    public partial class WbsMainForm : Form
    {
        //public List<Car> listCars = new List<Car>();
        //public List<Person> listPerson = new List<Person>();


        public WbsMainForm()
        {
            InitializeComponent();
            
        }

        // Car list
        private void CarListClick(object sender, EventArgs e)
        {
            DisableButtons();

            CarOverview car = new CarOverview();
            car.FormClosed += EnableButtons_FormClosed;
            car.Show();
        }

        // Person List
        private void PersonListClick(object sender, EventArgs e)
        {
            DisableButtons();

            PersonOverview person = new PersonOverview();
            person.FormClosed += EnableButtons_FormClosed;
            person.Show();
        }

        // Create car
        private void AddCarButtonClick(object sender, EventArgs e)
        {
            //DisableButtons();
            Car newCar = new Car();
           
            CarEditForm carEditForm = new CarEditForm(newCar);
            carEditForm.FormClosed += EnableButtons_FormClosed;
            carEditForm.Show();
        }

        // create Person 
        private void AddPersonButtonClick(object sender, EventArgs e)
        {
            DisableButtons();

            Person newPerson = new Person();

            PersonEditForm personEditForm = new PersonEditForm(newPerson);
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

        private void WbsMainForm_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> FleetItems = new Dictionary<int, string>();
            foreach (Fleet fleet in Program.db.Fleets)
            {
                FleetItems.Add(fleet.ID, fleet.Name);

                cb_Fleet.DataSource = new BindingSource(FleetItems, null);
                cb_Fleet.ValueMember = "Key";
                cb_Fleet.DisplayMember = "Value";
            }

            SetFleet();
        }

        private void SelectFleet_Click(object sender, EventArgs e)
        {
            SetFleet();
        }

        private void SetFleet()
        {
            SelectedFleet.Text = cb_Fleet.Text;
            int FleetId = (int)cb_Fleet.SelectedValue;
            Fleet.selectedID = FleetId;
        }

        private void cb_slectedFleet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
