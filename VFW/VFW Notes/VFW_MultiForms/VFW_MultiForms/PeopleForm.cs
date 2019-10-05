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
    public partial class PeopleForm : Form
    {

        public string CountDisplay
        {
            set
            {
                // set the textbox to show whatever value txtCount is
                txtCount.Text = value;
            }

        }


        public PeopleForm()
        {
            InitializeComponent();
        }


        // closes the form, but not the entire program
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
