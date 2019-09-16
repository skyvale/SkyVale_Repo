using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Skylar Valerio
 * 08.12.19
 * CE: Custom Events (CE03)
 * MDV1830-O 01
 */

namespace SkylarValerio_CE03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // closes the application
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
