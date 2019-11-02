using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_NewCustomEventsNotess
{
    public partial class InputForm : Form
    {
        // these are the event handler delegates
        public event EventHandler CloseAndCopy;
        public event EventHandler OnlyClose;

        // this bool determines if the user is using the button to close the form
        // and not the 'x' or anything else
        bool IsClosingAndCopying = false;

        // get and set the values 
        public DataHolder TextValues
        {
            set
            {
                txtFirstName.Text = value.FirstName;
                txtLastName.Text = value.LastName;
                txtAge.Text = value.Age;

            }
            get
            {
                DataHolder dataToGet = new DataHolder();
                dataToGet.FirstName = txtFirstName.Text;
                dataToGet.LastName = txtLastName.Text;
                dataToGet.Age = txtAge.Text;
                return dataToGet;
            }
        }

        // initializes the form
        public InputForm()
        {
            InitializeComponent();
        }

        // saves the input values to the DataHolder class and then closes the InputForm
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            // since the user clicked the button, the bool value of IsClosingAndCopying
            // becomes true
            IsClosingAndCopying = true;

            Close();
        }

        // if the user closes the form using the button, then this will trigger
        // the CloseAndCopy event
        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // this determines if the button is clicked
            // AND checks to make sure the event has a subscription
            if (IsClosingAndCopying && CloseAndCopy != null)
            {
                // calls the CloseAndCopy event, passes in the InputForm, and then
                // add new EventArgs just because it is a requirement (it doesn't do anything
                // in this particular instance though)
                CloseAndCopy(this, new EventArgs());
            }
            else if (OnlyClose != null)
            {
                OnlyClose(this, new EventArgs());
            }
        }


        public void CopyForward(object sender, EventArgs e)
        {
            // cast the sender as a new Form1 object
            Form1 copyData = (Form1)sender;
            TextValues = copyData.TextValues;

        }
    }
}
