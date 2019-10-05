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
    public partial class Form1 : Form
    {

        public event EventHandler CopyForward;

        public DataHolder TextValues
        {
            // this sets and gets the values in each textbox to their respective variable
            // in the DataHolder class
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

        // intiliazes the form
        public Form1()
        {
            InitializeComponent();
        }

        // exits the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            InputForm openInput = new InputForm();

            // these are the subscriptions to the event handlers created in the other form
            // they are here because the InputForm is what triggers these events to happen

            // connect the eventhandler CloseAndCopy from the InputForm with
            // the CloseAndCopy method in this form
            openInput.CloseAndCopy += OpenInput_CloseAndCopy;
            openInput.OnlyClose += OpenInput_OnlyClose;

            // this subscription can't use InputForm's methods to subscribe
            // dont use the tab shortcut since you already defined it in the other form
            CopyForward += openInput.CopyForward;


            CopyForward(this, new EventArgs());

            // this is modeless form so you just say Open instead of OpenDialog
            openInput.Show();
        }


        // if the user closes the form without hitting the button, it will clear out
        // anything that is showing in the original ReadOnly form
        private void OpenInput_OnlyClose(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
        }


        // this is the method created from the subscription CloseAndCopy
        private void OpenInput_CloseAndCopy(object sender, EventArgs e)
        {
            // remember that the sender object is the InputForm, so you have to cast it
            // as an InputForm here
            InputForm inputSender = (InputForm)sender;

            // this sets the TextValues of the other form to the TextValues of this form
            TextValues = inputSender.TextValues;
        }
    }
}
