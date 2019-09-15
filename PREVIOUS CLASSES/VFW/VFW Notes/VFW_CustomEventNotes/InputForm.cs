using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_CustomEventNotes
{
    public partial class InputForm : Form
    {
        // public event handler declarations
        public event EventHandler CloseAndCopy;
        public event EventHandler OnlyClose;

        // boolean variable to determine how the form was closed
        // set initially to false until the button is actually clicked
        public bool IsClosingAndCopying = false;

        // property for modifying and extracting the text box values (of DataHold)
        // copied and pasted from the Main Form
        public DataHold TextValues
        {
            // pulls the data from the text boxes
            get
            {
                DataHold d = new DataHold();
                d.firstName = txtFirstName.Text;
                d.lastName = txtLastName.Text;
                d.age = txtAge.Text;
                return d;
            }
            // sets the data from the text boxes
            set
            {
                txtFirstName.Text = value.firstName;
                txtLastName.Text = value.lastName;
                txtAge.Text = value.age;
            }
        }

        // initializes the form
        public InputForm()
        {
            InitializeComponent();
        }

        // this fires if the user clicks the CloseAndCopy button
        // closes the form and also copies the data to the DisplayForm (aka Form1)
        private void BtnCloseAndCopy_Click(object sender, EventArgs e)
        {
            // set the boolean to true to indicate the button was clicked
            IsClosingAndCopying = true;

            // close the form
            Close();
        }


        // this fires if the user closes the form without pressing the CloseAndCopy button
        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // this is the event handler that is called whenever the form closes
            // we need to do the check of how it was closed
            // we also need to make sure our custom event handlers are not null
            if (IsClosingAndCopying == true && CloseAndCopy != null)
            {
                // this = the form
                CloseAndCopy(this, new EventArgs());
            }
            else if (OnlyClose != null)
            {
                OnlyClose(this, new EventArgs());
            }

        }

        //
        public void CopyCurrentData(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)sender;
            TextValues = mainForm.TextValues;
        }

    }
}
