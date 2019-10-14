using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Sandbox
{
    public partial class Form1 : Form
    {
        public event EventHandler RandomDelegate;

        public Form1()
        {
            InitializeComponent();
        }

        public void Random()
        {
            ListViewItem lvi = new ListViewItem();
            
        }

        public void RandomEvent(object sender, EventArgs e)
        {

        }

   
    }

}
