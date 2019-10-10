using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_FancyCustomEvents
{
    public partial class SelectionForm : Form
    {
        // custom event class
        // define the custom class wherever the delegate for the custom event will be
        // remember that custom event classes inherit from EventArgs class
        public class ChangeClassArgs : EventArgs
        {
            // create an image index property and name property since you will need them in Form1      
            public int imageIndex;
            public string newName;

            // constructor
            // sets the new properties to the constructor's arguments
            public ChangeClassArgs(int index, string name)
            {
                this.newName = name;
                this.imageIndex = index;
            }

        }

        // delegate
        // allows the user to change the class of a character
        // make sure to specify what kind of event it will be using since its a custom event
        public event EventHandler<ChangeClassArgs> Change;


        public SelectionForm()
        {
            InitializeComponent();
        }


        // executable method
        // determines which radio button the user chooses when they want to change the class
        private void SelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // remember, ChangeClassArgs requires the index image
            // so first, you have to check the radio buttons to determine the index

            // set a default case in case the other checks fail
            int index = 0;

            // check the others
            // note, you can also use a switch statement for these
            if(rdRogue.Checked == true)
            {
                index = 1;
            }
            else if (rdMage.Checked == true)
            {
                index = 2;
            }
            else if (rdPriest.Checked == true)
            {
                index = 3;
            }

            // invoke the Change eventhandler
            // pass in the index to the ChangeClassArgs event
            // pass in the text from the textbox for the required name
            Change?.Invoke(this, new ChangeClassArgs(index, txtName.Text));
        }


        // eventhandler
        // gets the data from the SelectionForm in order to send it to Form1
        public void CatchData(object sender, ChangeClassArgs e)
        {
            // set the textbox text to the event class's newName property
            txtName.Text = e.newName;

            switch (e.imageIndex)
            {
                case 0:
                    rdWarrior.Checked = true;
                    break;
                case 1:
                    rdRogue.Checked = true;
                    break;
                case 2:
                    rdMage.Checked = true;
                    break;
                case 3:
                    rdPriest.Checked = true;
                    break;
                default:
                    rdWarrior.Checked = true;
                    break;
            }


        }



    }
}
