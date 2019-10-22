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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            // instantiate new UserInput form
            UserInput userInput = new UserInput();

            // show userInput as modal (user cannot interact with main form)
            userInput.ShowDialog();

        }
    }
}
