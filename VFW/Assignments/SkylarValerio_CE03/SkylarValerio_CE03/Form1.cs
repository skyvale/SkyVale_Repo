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
    public partial class Form1 : Form
    {

        // delegate to allow the student object to be added to the ListBox on the Display Form
        public event EventHandler AddToListBox;

        // determines if the user closes the form
        public event EventHandler IsClosed;

        // list to hold the Student objects (private)
        List<Student> studentList = new List<Student>();

        // accessor for the studentList (public)
        public List<Student> StudentList
        {
            get
            {
                return studentList;
            }
        }

        // property to hold all the variables
        public Student DataHold
        {
            get
            {
                Student createdStudent = new Student();
                createdStudent.FirstName = txtFirstName.Text;
                createdStudent.LastName = txtLastName.Text;
                createdStudent.Gender = rdMale.Checked;
                createdStudent.Program = comBoxProgram.Text;
                createdStudent.Above21 = chkAbove21.Checked;
                return createdStudent;
            }
            set
            {
                txtFirstName.Text = value.FirstName;
                txtLastName.Text = value.LastName;
                rdMale.Checked = value.Gender;
                comBoxProgram.Text = value.Program;
                chkAbove21.Checked = value.Above21;
            }
        }


        // initialize the Form
        public Form1()
        {
            InitializeComponent();
            rdMale.Checked = true;
        }


        // exits the entire program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // clears the form (just this form though)
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }


        // method to clear the inputs
        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            rdMale.Checked = true;
            comBoxProgram.SelectedIndex = -1;
            chkAbove21.Checked = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // adds the created object to the list
            studentList.Add(DataHold);
         
        }


        private void menuBtnCreate_Click(object sender, EventArgs e)
        {
            // make sure the DisplayForm isn't open (default is closed)
            // if it is, do not open another one
            if (menuBtnCreate.Checked == false)
            {
                // add checkmark next to the Created option in the MenuStrip when the form is opened
                menuBtnCreate.Checked = true;

                // create the Display form
                Display displayForm = new Display();

                // subscribe to the AddStudent method in the Display Form
                // so that you can add student to the ListBox there
                AddToListBox += displayForm.DisplayForm_AddStudent;
                IsClosed += displayForm.DisplayForm_CloseForm;

                // raise the eventhandler
                AddToListBox?.Invoke(this, new EventArgs());
                IsClosed?.Invoke(this, new EventArgs());

                // show the form (modeless)
                displayForm.Show();

            }
            else if (menuBtnCreate.Checked == true)
            {
                // needs to close the open window when clicked
                

            }

        }
    }
}
