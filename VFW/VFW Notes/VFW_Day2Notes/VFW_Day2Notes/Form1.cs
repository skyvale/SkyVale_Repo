using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_Day2Notes
{
    public partial class Form1 : Form
    {

        // property for the Person we want to store in the ListBox
        Person fieldData
        {
            get
            {
                Person returnObj = new Person();
                returnObj.firstName = txtFirstName.Text;
                returnObj.lastName = txtLastName.Text;
                returnObj.isStudent = chkIsStudent.Checked;
                return returnObj;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddToListBox_Click(object sender, EventArgs e)
        {
            // create the object and add it to the ListBox
            lstDataList.Items.Add(fieldData);

            // call the event handler to clear the form
            ClearForm_Event(this, new EventArgs());

        }
        

        // this method lets the user select an item from the ListBox and re-populates the data
        private void LstDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check to make sure the object is not null before trying to get data
            if (lstDataList.SelectedItem != null)
            {
                txtFirstName.Text = ((Person)lstDataList.SelectedItem).firstName;
                txtLastName.Text = ((Person)lstDataList.SelectedItem).lastName;
                chkIsStudent.Checked = ((Person)lstDataList.SelectedItem).isStudent;
            }

        }

        // when user clicks 'stats' in MenuStrip, create the PeopleCount form
        private void StatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate the new form (PeopleCount)
            PeopleCount statsDisplay = new PeopleCount();

            // send the ListBox count to the PeopleCount form using the CountDisplay public property within the form code
            // put it into a string (ToString) since its going to display in text box
            statsDisplay.CountDisplay = lstDataList.Items.Count.ToString();

            // show the form
            statsDisplay.ShowDialog();

        }

        // custom event handler that will clear the form
        public void ClearForm_Event(object sendor, EventArgs e)
        {
            // clear the user input controls
            txtLastName.Clear();
            txtFirstName.Clear();
            chkIsStudent.Checked = false;
        }
    }
}
