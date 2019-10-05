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
 * 10.02.19
 * CE: Passing Data & Multiple Forms
 * VFW
 */

namespace SkylarValerio_CE02
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }


        // displays count for items in the good listbox
        public string GoodCount
        {
            set
            {
                txtGoodCount.Text = value;
            }
        }


        // displays count for items in the evil listbox
        public string EvilCount
        {
            set
            {
                txtEvilCount.Text = value;
            }
        }

        // closes the display form
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
