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
    public partial class PersonOverview : Form
    {
        public List<Person> ListOfFilteredPersons;
        public List<Person> ListFleetPersons;

        public PersonOverview()
        {
            InitializeComponent();
            ShowList();
        }

        public void ShowList()
        {
            listViewPerson.Items.Clear();

            // Karim deze werkt nog niet maar volgens de documentatie zou die het wel moeten doen vanuit de relatie. https://msdn.microsoft.com/en-us/library/bb386932(v=vs.110).aspx
            var ListFleetPersons = (from listOfPerson in Program.db.Persons
                                    from car in Program.db.Cars
                                    where car.FleetID == Fleet.selectedID
                                    select listOfPerson).Distinct().ToList();


            var personfleet = (from car in Program.db.Cars
                               where car.FleetID == Fleet.selectedID
                               && car.OwnerID != null
                               select new { personlist = car.Person }).Distinct().ToList();



            if (ListOfFilteredPersons != null)
            {

                foreach (Person person in ListOfFilteredPersons)
                {
                    ListViewItem personlist = new ListViewItem();

                    personlist.Text = (person.FirstName);
                    personlist.SubItems.Add(person.LastName);
                    personlist.SubItems.Add(person.Birthday.ToString());
                    personlist.SubItems.Add(person.DriversLicense);
                    personlist.Tag = (person.ID);


                    // add them to the list.
                    listViewPerson.Items.Add(personlist);

                }
            }
            else
            {
                foreach (var person in personfleet)
                {
                    ListViewItem personlist = new ListViewItem();

                    personlist.Text = (person.personlist.FirstName);
                    personlist.SubItems.Add(person.personlist.LastName);
                    personlist.SubItems.Add(person.personlist.Birthday.ToString());
                    personlist.SubItems.Add(person.personlist.DriversLicense);
                    personlist.Tag = (person.personlist.ID);

                    // add them to the list.
                    listViewPerson.Items.Add(personlist);
                }
            }

        }

        private void editPersonClick(object sender, EventArgs e)
        {

            if (listViewPerson.SelectedItems.Count > 0)
            {
                DisableButtons();

                var PersonID = listViewPerson.SelectedItems[0].Tag;

                Person selectedPerson = Program.db.Persons.Find(PersonID);

                PersonEditForm personEditForm = new PersonEditForm(selectedPerson);
                personEditForm.FormClosed += Reload_FormClosed;
                personEditForm.Show();
            }


        }

        private void ReturnToMainMenuFromPersonList_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // check if there is something selected
            if (listViewPerson.SelectedItems.Count > 0)
            {
                var PersonID = listViewPerson.SelectedItems[0].Tag;

                Person selectedPerson = Program.db.Persons.Find(PersonID);

                if (selectedPerson.Cars.Count > 0)
                {
                    var SelectCar = (from car in Program.db.Cars
                                     where car.OwnerID == selectedPerson.ID
                                     select car).First();

                    selectedPerson.Cars.Remove(SelectCar);
                }
                Program.db.Persons.Remove(selectedPerson);
                Program.db.SaveChanges();
                ListOfFilteredPersons = null;
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
            Button_Edit_Person.Enabled = true;
            Button_Delete_Person.Enabled = true;
            Button_Filter.Enabled = true;
            button_Reset_Filter.Enabled = true;
        }

        private void DisableButtons()
        {
            Button_Return_To_Main_Menu.Enabled = false;
            Button_Edit_Person.Enabled = false;
            Button_Delete_Person.Enabled = false;
            Button_Filter.Enabled = false;
            button_Reset_Filter.Enabled = false;
        }

        private void Button_Filter_Click(object sender, EventArgs e)
        {
            DisableButtons();

            using (var formfilter = new PersonFilterForm())
            {
                var result = formfilter.ShowDialog();
                if (result == DialogResult.OK)
                {

                    ListOfFilteredPersons = formfilter.ListOfFilteredPersons;
                    ShowList();

                }
            }

            EnableButtons();
        }

        private void Button_Reset_Filter_Click(object sender, EventArgs e)
        {
            ListOfFilteredPersons = null;
            ShowList();
        }

    }
}
