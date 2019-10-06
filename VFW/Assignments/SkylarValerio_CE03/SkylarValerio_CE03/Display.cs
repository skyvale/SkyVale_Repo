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

        // delegate to repopulate the inputs when the user chooses an item from the ListBox
        public event EventHandler<StudentEventArgs> RepopulateInputs;

        // initiate the Display Form
        public Display()
        {
            InitializeComponent();
        }


        // executable method for AddToListBox eventhandler
        // the sender is the object version of Form1
        public void DisplayForm_AddStudent(object sender, EventArgs e)
        {
            // adds students from the studentList to the ListBox
            foreach (Student student in ((Form1)sender).StudentList)
            {
                listBoxStudents.Items.Add(student);
            }
        }
        

        private void ListBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make new custom event
            StudentEventArgs studentEvent = new StudentEventArgs();        

            // gets the selected student
            Student student = ((Student)listBoxStudents.SelectedItem);

            // target the properties in one to the empty properties in the other
            studentEvent.FirstName = student.FirstName;
            studentEvent.LastName = student.LastName;
            studentEvent.Gender = student.Gender;
            studentEvent.Program = student.Program;
            studentEvent.Above21 = student.Above21;

            // invoke the repopulate index eventhandler with the custom event 
            RepopulateInputs?.Invoke(this, studentEvent);
        }
    }
}
