using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_Day4Notes
{
    public partial class DataEntryForm : Form
    {
        // declare the event handler to subscribe to the ListView's method
        public event EventHandler AddCharacter;


        // public property to create the objects
        public DataClass Data
        {
            get
            {
                DataClass c = new DataClass();
                c.Age = numAge.Value;
                c.Name = txtName.Text;
                c.Gender = cmbGender.Text;
                c.Immortal = chkImmortal.Checked;
                c.ClassName = cmbClass.Text;
                // this next one will get the index number of the class selected in the comboBox
                c.ImageIndex = cmbClass.SelectedIndex;

                return c;

            }
            set
            {
                numAge.Value = value.Age;
                txtName.Text = value.Name;
                cmbGender.Text = value.Gender;
                chkImmortal.Checked = value.Immortal;
                cmbClass.Text = value.ClassName;

            }
           

        }


        public DataEntryForm()
        {
            InitializeComponent();
        }


        // exits the application
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // check that the event handler has subscribed to a method
            if (AddCharacter != null)
            {
                // make the sender for this event the form
                AddCharacter(this, new EventArgs());
            }

            ClearForm();
        }

        // event handler method to popualte the form
        public void listBoxForm_PopulateForm(object sender, EventArgs e)
        {
            // get the data from the selected ListBox item
            // this references the Data setter property
            Data = (sender as DataClass);
        }


        // method to clear the form
        private void ClearForm()
        {
            txtName.Clear();
            cmbClass.Text = "";
            cmbGender.Text = "";
            numAge.Value = 0;
            chkImmortal.Checked = false;
        }
    }
}
