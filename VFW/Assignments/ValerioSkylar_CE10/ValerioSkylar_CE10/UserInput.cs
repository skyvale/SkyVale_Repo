using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValerioSkylar_CE10
{
    public partial class UserInput : Form
    {
        // initializes the form
        public UserInput()
        {
            InitializeComponent();
        }


        // closes the input form without saving
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
