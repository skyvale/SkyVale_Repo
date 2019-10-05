using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_MultiForms
{
    public partial class Form1 : Form
    {
        // you put the getter here so you dont have to manually set the information each time
        // just saves some time, but there are other ways to do this
        Person fieldData
        {
            get
            {
                Person returnObject = new Person();
                returnObject.Firstname = txtFirstName.Text;
                returnObject.Lastname = txtLastName.Text;
                returnObject.Student = chkStudent.Checked;
                return returnObject;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // exits from the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // saves the object to the listbox
        private void btnAddToListbox_Click(object sender, EventArgs e)
        {
            // must be a String class because a Listbox only takes objects, not variables (string)
            // this is a method of doing things, but not the most correct way
            /*String allInfo = txtFirstName.Text + " " + txtLastName.Text + " " + chkStudent.Checked;
            *listBox.Items.Add(allInfo);
            */

            // give the listbox the new person object
            listBox.Items.Add(fieldData);

        }

        // this method will clear the inputs when called
        private void clearInputs()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            chkStudent.Checked = false;
        }

        //this method will re-populate the form
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedItem != null)
            {
                // you have to caste SelectedItem as a Person because the compiler doesn't
                // know that SelectedItem is a Person until you tell it
                txtFirstName.Text = ((Person)listBox.SelectedItem).Firstname;
                txtLastName.Text = ((Person)listBox.SelectedItem).Lastname;
                chkStudent.Checked = ((Person)listBox.SelectedItem).Student;
            }
        }

        // opens the separate People Count window
        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // first you must create the new form, because it doesnt exist yet
            PeopleForm peopleCountForm = new PeopleForm();

            // set the value of CountDisplay (which will be the count of items in the listbox)
            // add the ToString because you're setting it to a string object (Text)
            peopleCountForm.CountDisplay = listBox.Items.Count.ToString();

            // remember that ShowDialog prevents the user from being able to use Form1 while the new
            // form is open
            peopleCountForm.ShowDialog();

            
        }
    }
}
