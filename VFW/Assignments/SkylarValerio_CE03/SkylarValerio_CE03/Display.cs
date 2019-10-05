using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkylarValerio_CE03
{
    public partial class Display : Form
    {
        public event EventHandler CloseChildForm;

        // initiate the Display Form
        public Display()
        {
            InitializeComponent();
        }


        // the sender is the object version of Form1
        public void DisplayForm_AddStudent(object sender, EventArgs e)
        {
            // adds students from the studentList to the ListBox
            foreach (Student student in ((Form1)sender).StudentList)
            {
                listBoxStudents.Items.Add(student);
            }
        }

        private void Display_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
