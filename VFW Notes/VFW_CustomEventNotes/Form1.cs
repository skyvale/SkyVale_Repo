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
    public partial class Form1 : Form
    {
        // initializes the form
        public Form1()
        {
            InitializeComponent();
        }

        // public event handler to subscribe to an event handler on the InputForm
        public event EventHandler CopyCurrentData;

        // property for modifying and extracting the text box values (of DataHold)
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


        //
        private void BtnOpenInputForm_Click(object sender, EventArgs e)
        {
            // instantiate the InputForm
            InputForm newWindow = new InputForm();

            // set the new window's events to be handled
            // subscribe to the new CloseAndCopy method
            newWindow.CloseAndCopy += NewWindow_CloseAndCopy;
            newWindow.OnlyClose += NewWindow_OnlyClose;

            // subscribe to the CopyCurrentData method on newWindow
            CopyCurrentData += newWindow.CopyCurrentData;

            // show form as modeless (allows the user to interact with all open windows)
            newWindow.Show();
        }


        //
        private void NewWindow_OnlyClose(object sender, EventArgs e)
        {
            // clear the text boxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();

        }


        //
        private void NewWindow_CloseAndCopy(object sender, EventArgs e)
        {
            // when we call this method, the InputForm will be closed
            // but, the sender object IS the InputForm, which will have all the data from that form
            // so we can access that property by instantiating the sender form as a new InputForm

            // create a new instance of the sender as InputForm
            // remember, the sender is just a generic object, so it will need to be casted
            InputForm theInputForm = (InputForm)sender;

            // get the text values from the closed window and set the MainForm fields to those values
            TextValues = theInputForm.TextValues;
        }
    }
}
