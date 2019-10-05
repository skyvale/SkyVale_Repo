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
    public partial class PeopleCount : Form
    {
        // public property to receive the count
        public string CountDisplay
        {
            set
            {
                txtNumOfPpl.Text = value;
            }
        }


        public PeopleCount()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // closes the form without exiting the application
            Close();
        }
    }
}
