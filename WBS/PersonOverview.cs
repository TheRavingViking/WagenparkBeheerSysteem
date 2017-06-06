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
    public partial class PersonOverview : Form
    {

        public List<Person> listOfPersons;
        public List<Person> ListOfFilteredPersons;



        public PersonOverview(List<Person> persons)
        {
            InitializeComponent();
            listOfPersons = persons;
            ShowList();


        }

        public void ShowList()
        {
            listViewPerson.Items.Clear();

            if (ListOfFilteredPersons != null)
            {

                foreach (Person person in ListOfFilteredPersons)
                {
                    ListViewItem personlist = new ListViewItem();

                    personlist.Text = (person.FirstName);
                    personlist.SubItems.Add(person.LastName);
                    personlist.SubItems.Add(person.Birthday);
                    personlist.SubItems.Add(person.DriversLicense);

                    // add them to the list.
                    listViewPerson.Items.Add(personlist);

                }
            }
            else
            {
                foreach (Person person in listOfPersons)
                {
                    ListViewItem personlist = new ListViewItem();

                    personlist.Text = (person.FirstName);
                    personlist.SubItems.Add(person.LastName);
                    personlist.SubItems.Add(person.Birthday);
                    personlist.SubItems.Add(person.DriversLicense);

                    // add them to the list.
                    listViewPerson.Items.Add(personlist);

                }
            }
        }




        private void editPersonClick(object sender, EventArgs e)
        {
            DisableButtons();
            PersonEditForm personEditForm = new PersonEditForm(listOfPersons[listViewPerson.SelectedIndices[0]]);
            personEditForm.FormClosed += Reload_FormClosed;
            personEditForm.Show();
        }

        private void ReturnToMainMenuFromPersonList_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listOfPersons.Count != 0)
            {
                if (listViewPerson.Items[listViewPerson.SelectedIndices[0]].Selected)
                {
                    listOfPersons.RemoveAt(listViewPerson.SelectedIndices[0]);
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

            using (var formfilter = new PersonFilterForm(listOfPersons))
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
