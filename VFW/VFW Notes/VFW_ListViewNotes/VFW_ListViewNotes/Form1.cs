using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_ListViewNotes
{
    public partial class Form1 : Form
    {
        // the delegate should always go into the class that
        // will call the method
        // the class that is going to receive the event is going to have the eventhandler

        // the goal of this event handler is to add a new character
        // to the ListView
        public event EventHandler AddCharacter;

        public DataClass Data
        {
            get
            {
                DataClass c = new DataClass();
                c.Name = txtName.Text;
                c.Age = numAge.Value;
                c.Gender = comBoxGender.Text;
                c.Immortal = chkImmortal.Checked;
                c.ClassName = comBoxClass.Text;
                c.ImageIndex = comBoxClass.SelectedIndex;
                return c;
            }
            set
            {
                txtName.Text = value.Name;
                numAge.Value = value.Age;
                comBoxGender.Text = value.Gender;
                chkImmortal.Checked = value.Immortal;
                comBoxClass.Text = value.ClassName;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        // when the user closes the form, the entire application will end
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        // adds the created character to the ListView
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // invoke the custom AddCharacter where you want the method to happen 
            // remember that 'this' = Form1
            AddCharacter?.Invoke(this, new EventArgs());
        }
    }
}
