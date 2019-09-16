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
 * 08.11.19
 * CE02: Passing Data and Multiple Forms
 * MDV1830-O 01
 */

namespace SkylarValerio_CE02
{
    public partial class FighterCount : Form
    {
        public FighterCount()
        {
            InitializeComponent();
        }

        // displays count for Team Dream
        public string CountDream
        {
            set
            {
                txtNumDream.Text = value;
            }
        }

        // displays count for Team Nightmare
        public string CountNightmare
        {
            set
            {
                txtNumNightmare.Text = value;
            }
        }

        // closes form
        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
